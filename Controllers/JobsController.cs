using JobBoard.Cosmos;
using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobBoard.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobsController : Controller
    {
        public IDB db;

        public JobsController(IDB db)
        {
            this.db = db;
        }

        public IActionResult Jobs()
        {
            return new JsonResult(db.ReadJobs());
        }
        [HttpGet("{id}")]
        public IActionResult Jobs(int id) {

            return new JsonResult(db.ReadJobWithId(id.ToString()));
        }
        [HttpPost]
        public IActionResult Submit([FromBody] Job job) {
            var res = db.InsertJob(job);
            return new ContentResult
            {
                Content = res,
                StatusCode = res.Equals("Success") ? 200 : 400,
                ContentType = "Text"
            };
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Job job)
        {
            var res = db.UpdateJob(job);
            return new ContentResult
            {
                Content = res,
                ContentType = "Text",
                StatusCode = res.Equals("Success") ? 200 : 400
            };
        }
    }
}
