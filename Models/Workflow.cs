namespace JobBoard.Models
{
    public class Workflow
    {
        List<Stage> Stages { get; set; }

        public Workflow()
        {
            
        }

        public Workflow(List<Stage> stages)
        {
            Stages = stages;
        }
    }
}
