using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotLive02.Shared.Models
{
    public class JobApplicationViewModel
    {
        public JobApplicationViewModel(Guid id, Guid jobId, string title, string description, string company, string location, decimal salary, DateTime appliedAt)
        {
            Id = id;
            JobId = jobId;
            Title = title;
            Description = description;
            Company = company;
            Location = location;
            Salary = salary;
            AppliedAt = appliedAt;
        }

        public Guid Id { get; private set; }
        public Guid JobId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Company { get; private set; }
        public string Location { get; private set; }
        public decimal Salary { get; private set; }
        public DateTime AppliedAt { get; private set; }
    }
}
