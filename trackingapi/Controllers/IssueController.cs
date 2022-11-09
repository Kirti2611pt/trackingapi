using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using trackingapi.Data;
using trackingapi.Models;

namespace trackingapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : ControllerBase
    {
        private readonly IssueDbContext _context;
        public IssueController(IssueDbContext context)=> _context=context;
        [HttpGet]
        public async Task<IEnumerable<Issue>> Get()
            => await _context.Issues.ToListAsync();
    }
}
