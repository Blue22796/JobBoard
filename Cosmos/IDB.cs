using JobBoard.Models;

namespace JobBoard.Cosmos
{
    public interface IDB{
        public void CreateDBAndContainerAsync();
        public String InsertJob(Job job);
        public List<Job> ReadJobs();
        public Job ReadJobWithId(String id);
        public String UpdateJob(Job job);
        public ApplicationTemplate ReadTemplateWithId(String id);
        public Workflow ReadWorkflowWithId(String id);


    }
}
