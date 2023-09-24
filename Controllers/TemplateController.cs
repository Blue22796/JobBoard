using JobBoard.Cosmos;
using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobBoard.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemplateController : Controller
    {
        
        public IDB db;

        public TemplateController(IDB db)
        {
            this.db = db;
        }

        public IActionResult Template(int id)
        {
            return new JsonResult(db.ReadTemplateWithId(id.ToString()));
        }

        [HttpPut("{id}")]
        public IActionResult Template(int id, [FromBody] ApplicationTemplate template) {
            var job = db.ReadJobWithId(id.ToString());
            job.Template = template;
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
