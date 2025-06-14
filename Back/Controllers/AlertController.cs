using Back.Data;
using Back.Models;
using Back.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Back.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlertController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly AlertService _alertService;

    public AlertController(AppDbContext context, AlertService alertService)
    {
        _context = context;
        _alertService = alertService;
    }

    [HttpGet]
    public IActionResult GetAlerts()
    {
        try
        {
            var alerts = _alertService.GetAlerts();
            return Ok(alerts);
        }
        catch (SystemException ex)
        {
            return NotFound(new { message = ex.Message });
        }
    }

    [HttpGet("{id}")]
    public IActionResult GetAlertById(int id)
    {
        try
        {
            var alert = _alertService.GetAlert(id);
            return Ok(alert);
        }
        catch (SystemException ex)
        {
            return NotFound(new { message = ex.Message });
        }
    }

    [HttpPost]
    public IActionResult CreateAlert([FromBody] Alert alertData)
    {
        try
        {
            _alertService.CreateAlert(alertData);
            return Created();
        }
        catch (SystemException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateAlert(int idAlert)
    {
        try
        {
            var alert = _alertService.UpdateAlert(idAlert);
            return Ok(alert);
        }
        catch (SystemException ex)
        {
            return NotFound(new { message = ex.Message });
        }
    }

    [HttpDelete]
    public IActionResult DeleteAlert(int idAlert)
    {
        try
        {
            _alertService.DeleteAlert(idAlert);
            return NoContent();
        }
        catch (SystemException ex)
        {
            return NotFound(new { message = ex.Message });
        }
    }
}