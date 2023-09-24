namespace JobBoard.Models
{
    public class Stage
    {
        StageType Type { get; set; }

        public Stage(StageType type)
        {
            this.Type = type;
        }

        public Stage() { }

    }

    public enum StageType
    {
        Shortlisting,
        VideoInterView,
        Placement
    }
}
