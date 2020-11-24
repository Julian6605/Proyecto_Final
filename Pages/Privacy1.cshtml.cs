using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using WebApp1.Data;
using WebApp1.Model;
using Microsoft.EntityFrameworkCore;

namespace WebApp1.Pages
{
    [Authorize]
    public class Privacy1Model : PageModel
    {
        
         
        private readonly ILogger<Privacy1Model> _logger;

    

        private readonly ApplicationDbContext _db;

        public Privacy1Model (ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Subastas> Subastar {get;set;}

        public async Task OnGet()
        {
            Subastar = await _db.Subastas.ToListAsync();
        }

        [TempData]
        public string Mensaje {get;set;}

    
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var Subastas = await _db.Subastas.FindAsync(id);
            if(Subastas == null)
            {
                return NotFound();
            }

            _db.Subastas.Remove(Subastas);
            await _db.SaveChangesAsync();

            Mensaje = "Registro borrado exitosamente";

            return RedirectToPage("Privacy1");
        }
    }
}
