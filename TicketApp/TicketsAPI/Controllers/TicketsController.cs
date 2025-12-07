using Microsoft.AspNetCore.Mvc;

namespace TicketsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTickets()
        {
            var tickets = new List<object>
            {
                new {
                    Id = 1,
                    ShortDescription = "Login issue",
                    Description = "User cannot login even with correct credentials.",
                    CreatedDate = new DateTime(2025, 6, 15),
                    Severity = "High",
                    TargetDate = new DateTime(2025, 6, 20),
                    Status = "Open"
                },
                new {
                    Id = 2,
                    ShortDescription = "UI alignment",
                    Description = "Buttons not aligned properly on tickets page.",
                    CreatedDate = new DateTime(2025, 6, 10),
                    Severity = "Medium",
                    TargetDate = new DateTime(2025, 6, 18),
                    Status = "In Progress"
                }
            };

            return Ok(tickets);
        }
    }
}
