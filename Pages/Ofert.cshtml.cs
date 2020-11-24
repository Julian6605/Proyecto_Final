using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using WebApp1.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApp1.Data;

namespace WebApp1.Pages
{
    [Authorize]
      public class OfertModel : PageModel
    {
        private readonly ILogger<OfertModel> _logger;

    

        private readonly ApplicationDbContext _db;
        public OfertModel(ApplicationDbContext db)
        {
            _db = db;
        }  


        [BindProperty]
        public  Ofertar Ofertar {get;set;}



        [TempData]
        public string Mensaje {get;set;}


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {

            if(!ModelState.IsValid)
            {
                return Page();
            }

            _db.Add(Ofertar);
            await _db.SaveChangesAsync();
            Mensaje = "Se realizo la oferta del articulo de manera exitosa";
            return RedirectToPage("Comprar");

        }

    }
}
