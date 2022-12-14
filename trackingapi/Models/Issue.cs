using System.ComponentModel.DataAnnotations;

namespace trackingapi.Models
{
    public class Issue
    {
        [Required]
        public int Id { get; set; }

        private string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public IssueType IssueType { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }
    }
    public enum Priority
    {
        Low,Medium, High
    }
    public enum IssueType
    {
        Feature,Bug,Documentation
    }
}
