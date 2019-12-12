using Microsoft.AspNetCore.Mvc;
using aspnetcore.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace aspnetcore.Controllers 
{   
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    
    public class ValuesController : ControllerBase {

        private readonly DataContext _context;
        public ValuesController(DataContext context ){
            _context = context;
        }
    
    //api/values
    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> GetValues(){
        var values = await _context.Values.ToListAsync();
        return Ok(values);
    }
    [AllowAnonymous]
    [HttpGet("{id}")]
    
    public async Task<IActionResult> GetValue(int id){
        var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
        if (value == null){
            return NotFound();
        }
        return Ok(value);   
    }
    }
}