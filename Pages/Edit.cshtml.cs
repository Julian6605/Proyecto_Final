using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp1.Data;
using WebApp1.Model;

namespace WebApp1.Pages

{
    public class EditModel : PageModel
    {

        public readonly ApplicationDbContext _db;
      
        public EditModel(ApplicationDbContext db)
      {
          _db=db;

      }

        [BindProperty]
        public Subastas subastas {get; set;}
        
        [TempData]
        public string Mensaje {get; set;}
        public async Task OnGet(int id)
        {
            subastas = await _db.Subastas.FindAsync(id);
        }

        public async Task<IActionResult> OnPost(){
            
            if(ModelState.IsValid){
                var subastasDesdeDb = await _db.Subastas.FindAsync(subastas.IdSubastas);
                subastasDesdeDb.NombreUsuario = subastas.NombreUsuario;
                subastasDesdeDb.ApellidoUsuario = subastas.ApellidoUsuario;
                subastasDesdeDb.NombreArticulo = subastas.NombreArticulo;
                subastasDesdeDb.DescripcionArticulo = subastas.DescripcionArticulo;
                subastasDesdeDb.Categoria = subastas.Categoria;
                subastasDesdeDb.Precio = subastas.Precio;
                subastasDesdeDb.FechaSubasta = subastas.FechaSubasta;
                subastasDesdeDb.FechaFinSubasta = subastas.FechaFinSubasta;

                await _db.SaveChangesAsync();
                Mensaje="Registro editado exitosamente";
                return RedirectToPage("Privacy1");
            }
                return RedirectToPage();
        }
    }
}