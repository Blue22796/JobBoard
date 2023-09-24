namespace JobBoard.Models
{
    public class Job{
        public String id { get; set; }
        public String Type { set; get; }
        public String Title { set; get; }
        public String Summary { set; get; }
        public String Description { set; get; }
        public int Duration { set; get; }
        public int MaxNumberofApplications { set; get; }
        public String ProgramBenefits { set; get; }
        public String ApplicationCriteria { set; get; }
        public Qualification MinQualification { get; set; }
        public DateOnly Start { get; set; }
        public DateOnly End { get; set; }
        public String Location { get; set; }
        public List<String> Skills { get; set; }
        public ApplicationTemplate Template { get; set; }
        public Workflow Flow { get; set; }

        public Job(string id, string type, string title, string summary, string description, int duration, int maxNumberofApplications, string programBenefits, string applicationCriteria, Qualification minQualification, DateOnly start, DateOnly end, string location, List<string> skills)
        {
            this.id = id;
            Type = type;
            Title = title;
            Summary = summary;
            Description = description;
            Duration = duration;
            MaxNumberofApplications = maxNumberofApplications;
            ProgramBenefits = programBenefits;
            ApplicationCriteria = applicationCriteria;
            MinQualification = minQualification;
            Start = start;
            End = end;
            Location = location;
            Skills = skills;
        }

        public Job(){
        
        }
    }

    public enum Qualification
    {
        None,
        Highschool,
        Diploma,
        University,
        Masters,
        PhD
    }

}
