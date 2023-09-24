namespace JobBoard.Models
{
    public class ApplicationTemplate
    {
        public List<Question> PersonalInformation { get; set; }
        public String Profile { get; set; }

        public List<Question> AdditionalQuestions { get; set; }
    }
}
}
