using Microsoft.AspNetCore.Mvc;

namespace MentoryWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MentoryLessonsController: ControllerBase
    {
        [HttpGet(Name = "GetGroupList")]
        public IEnumerable<string> Get()
        {
            return new List<string> { "Group 1", "Group 2", "Group 3" };        
        }
    }
}
