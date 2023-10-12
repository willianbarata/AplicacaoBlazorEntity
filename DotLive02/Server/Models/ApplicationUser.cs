using DotLive02.Server.Entities;
using Microsoft.AspNetCore.Identity;

namespace DotLive02.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<JobApplication> JobApplications { get; private set; }
    }
}