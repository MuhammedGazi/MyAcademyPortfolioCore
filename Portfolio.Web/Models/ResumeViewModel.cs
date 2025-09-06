using Portfolio.Web.Entities;

namespace Portfolio.Web.Models
{
    public class ResumeViewModel
    {
        public About AboutInfo { get; set; }
        public List<Education> Educations { get; set; }
        public List<Experience> Experiences { get; set; }
    }
}
