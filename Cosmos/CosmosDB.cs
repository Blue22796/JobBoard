using JobBoard.Models;
using Microsoft.Azure.Cosmos;
using Newtonsoft.Json.Linq;

namespace JobBoard.Cosmos
{
    public class CosmosDB{
        static private CosmosDB _instance;
        static public CosmosDB Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CosmosDB();
                return _instance;
            }
        }
        private CosmosClient Client { get; set; }
        private Database DB { get; set; }
        private Container JobsContainer { get; set; }


        private CosmosDB() {
            Client = new CosmosClient("AccountEndpoint=https://localhost:8081/;AccountKey=C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==");
            CreateDBAndContainerAsync();
        }
        public void CreateDBAndContainerAsync()
        {
            string containerId = "Jobs";
            string partitionKeyPath = "/Type";

            UniqueKeyPolicy uniqueKeyPolicy = new UniqueKeyPolicy
            {
                UniqueKeys =
                {
                    new UniqueKey { Paths = { "/Id" } } 
                }
            };
            
            DB = Client.CreateDatabaseIfNotExistsAsync("JobBoard").Result;
            JobsContainer = DB.CreateContainerIfNotExistsAsync(new ContainerProperties
            {
                Id = containerId,
                PartitionKeyPath = partitionKeyPath,
                UniqueKeyPolicy = uniqueKeyPolicy
            }).Result;
        }

     

        public String InsertJob(Job job)
        {
            try{
                JobsContainer.CreateItemAsync(job).Wait();
                return "Success";
            }
            catch(Exception ex) {
                return ex.Message;
            }
        }

        public List<Job> ReadJobs() {
            String query = $"select * from c";
            var definition = new QueryDefinition(query);
            var res = JobsContainer.GetItemQueryIterator<Job>(definition);
            List<Job> result = new List<Job>();
            foreach(var job in res.ReadNextAsync().Result)
                result.Add(job);
            return result;
        }

        public Job ReadJobWithId(String id)
        {
            String query = $"select * from c where c.id = {id}";
            var definition = new QueryDefinition(query);
            var res = JobsContainer.GetItemQueryIterator<Job>(definition);
            try
            {
                var job = res.ReadNextAsync().Result.First();
                return job;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public String UpdateJob(Job job)
        {
            try
            {
            JobsContainer.ReplaceItemAsync<Job>(job, job.id.ToString()).Wait();
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
