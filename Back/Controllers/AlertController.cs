using Back.Data;
using Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Back.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlertController : ControllerBase
{
    private readonly AppDbContext _context;

    public AlertController(AppDbContext context)
    {
        _context = context;
    }
    
    [HttpGet("GetAlerts")]
    public async Task<ActionResult<IEnumerable<Alert>>> GetAlerts()
    {
        return await _context.Alerts.Include(a => a.Recipients).ToListAsync();
    }
}