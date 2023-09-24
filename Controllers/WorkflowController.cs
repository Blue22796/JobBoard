using JobBoard.Cosmos;
using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobBoard.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkflowController : Controller
    {

        public IDB db;

        public WorkflowController(IDB db)
        {
            this.db = db;
        }
        public IActionResult Workflow(int id)
        {
            return new JsonResult(db.ReadWorkflowWithId(id.ToString()));
        }

        [HttpPut("{id}")]
        public IActionResult Flow(int id, [FromBody] Workflow flow)
        {
            var job = db.ReadJobWithId(id.ToString());
            job.Flow= flow;
            var res = db.UpdateJob(job);
            return new ContentResult
            {
                Content = res,
                StatusCode = res.Equals("Success") ? 200 : 400,
                ContentType = "Text"
            };
        }

    }
}
