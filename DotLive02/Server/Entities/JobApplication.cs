namespace DotLive02.Server.Entities
{
    public class JobApplication
    {
        public JobApplication(string userId, Guid jobId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            JobId = jobId;
            AppliedAt = DateTime.Now;
        }

        public Guid Id { get; set; }
        public string UserId { get; set; }
        public Guid JobId { get; set; }
        public Job Job { get; set; }
        public DateTime AppliedAt { get; set; }
    }
}
