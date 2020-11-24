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
      public class crearSubastasModel : PageModel
    {
        private readonly ILogger<crearSubastasModel> _logger;

    
        private readonly ApplicationDbContext _db;
        public crearSubastasModel(ApplicationDbContext db)
        {
            _db = db;
        }  


        [BindProperty]
        public  Subastas Subastas {get;set;}



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

            _db.Add(Subastas);
            await _db.SaveChangesAsync();
            Mensaje = "Resgitro del articulo exitoso";
            return RedirectToPage("Privacy1");

        }

    }
}

