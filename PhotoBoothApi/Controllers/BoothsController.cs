using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhotoBoothApi.Models;

namespace PhotoBoothApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BoothsController : ControllerBase
  {
    private readonly PhotoBoothApiContext _db;

    public BoothsController(PhotoBoothApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Booth>>> Get()
    {
      return await _db.Booths.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Booth>> GetBooth(int id)
    {
      Booth booth = await _db.Booths.FindAsync(id);

      if (booth == null)
      {
        return NotFound();
      }

      return booth;
    }
  }
}