using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;
using ClinicServicesWebAPI.Services;

namespace ClinicServicesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private IFeedback ifeedback;
        public FeedbackController(IFeedback ifeedback)
        {
            this.ifeedback = ifeedback;
        }
        [HttpGet()]
        public async Task<IEnumerable<Feedback>> GetFeedbacks()
        {
            return await ifeedback.GetFeedbacks();
        }
        [HttpGet("{feedbackID}")]
        public async Task<Feedback> GetFeedback(int feedbackID)
        {
            return await ifeedback.GetFeedback(feedbackID);
        }
        [HttpPost()]
        public async Task<Feedback> PostFeedbacks(Feedback feedback)
        {
            return await ifeedback.PostFeedbacks(feedback);
        }
        [HttpPut()]
        public async Task<Feedback> PutFeedbacks(Feedback feedback)
        {
            return await ifeedback.PutFeedbacks(feedback);
        }
        [HttpDelete("{feedbackID}")]
        public async Task<Feedback> DeleteFeedback(int feedbackID)
        {
            return await ifeedback.DeleteFeedback(feedbackID);
        }
    }
}
