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

    [HttpPost]
    public async Task<ActionResult<Booth>> Post(Booth booth)
    {
      _db.Booths.Add(booth);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetBooth), new { id = booth.BoothId }, booth);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Booth booth)
    {
      if (id != booth.BoothId)
      {
        return BadRequest();
      }

      _db.Booths.Update(booth);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BoothExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool BoothExists(int id)
    {
      return _db.Booths.Any(e => e.BoothId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBooth(int id)
    {
      Booth booth = await _db.Booths.FindAsync(id);
      if (booth == null)
      {
        return NotFound();
      }

      _db.Booths.Remove(booth);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}