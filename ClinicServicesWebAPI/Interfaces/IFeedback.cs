using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
   public interface IFeedback
    {
        Task<IEnumerable<Feedback>> GetFeedbacks();
        Task<Feedback> GetFeedback(int feedbackID);
        Task<Feedback> PostFeedbacks(Feedback feedback);
        Task<Feedback> PutFeedbacks(Feedback feedback);
        Task<Feedback> DeleteFeedback(int feedbackID);

    }
}
