namespace JobBoard.Models
{
    public class Question{
        public QType Type { get; set; }
        public String Statement { get; set; }
        public List<String> Choices { get; set; }
        public Question(QType type, String statement)
        {
            Type = type;
            Statement = statement;
        }

        public Question() { }

    }

    public enum QType {
        Paragraph, 
        ShortAnswer, 
        YesNo, 
        Dropdown, 
        MultipleChoice, 
        Date, 
        Number, 
        FileUpload
    }
}
