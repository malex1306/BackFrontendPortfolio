using Microsoft.AspNetCore.Mvc;
using ModernPorfolioBackend.Data;
using ModernPorfolioBackend.Models;

namespace ModernPorfolioBackend.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ContactController : ControllerBase
{
    private readonly AppDbContext _context;
    public ContactController(AppDbContext context) => _context = context;

    [HttpPost]
    public async Task<IActionResult> Post(ContactForm form)
    {
        _context.ContactForms.Add(form);
        await _context.SaveChangesAsync();
        return Ok(new { message = "Contact form created successfully" });
    }
}