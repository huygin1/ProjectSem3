using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.DataConnect;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
    public class FeedbackServices : IFeedback
    {
        private ClinicContext context;
        public FeedbackServices(ClinicContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Feedback>> GetFeedbacks()
        {
            return context.Feedback.ToList();
        }

        public async Task<Feedback> GetFeedback(int feedbackID)
        {

            Feedback fb = context.Feedback.SingleOrDefault(s => s.FeedbackID.Equals(feedbackID));
            if (fb != null)
            {
                return fb;
            }
            else
            { return null; }
        }

       

        public async Task<Feedback> PostFeedbacks(Feedback feedback)
        {
            context.Feedback.Add(feedback);
            context.SaveChanges();
            return feedback;
        }

        public async Task<Feedback> PutFeedbacks(Feedback feedback)
        {
            Feedback model = context.Feedback.SingleOrDefault(s => s.FeedbackID.Equals(feedback.FeedbackID));
            if (model != null)
            {
                model.FeedbackStar = feedback.FeedbackStar;
                model.FeedbackContent = feedback.FeedbackContent;
                model.FeedbackDate = feedback.FeedbackDate;
                model.FeedbackLock = feedback.FeedbackLock;
                model.AccountID = feedback.AccountID;
                model.MedicineID = feedback.MedicineID;
                model.Medi_Equip_ID = feedback.Medi_Equip_ID;

                context.SaveChanges();
                return feedback;
            }
            else
            {
                return null;
            }
        }
        public async Task<Feedback> DeleteFeedback(int feedbackID)
        {
            Feedback fb = context.Feedback.Where(n => n.FeedbackID.Equals(feedbackID)).FirstOrDefault();
            if (fb != null)
            {
                context.Feedback.Remove(fb);
                context.SaveChanges();

            }
            else
            {
                //no thing 
            }
            return null;
        }
    }
}
