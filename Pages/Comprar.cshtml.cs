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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp1.Pages
{
    public class ComprarModel : PageModel
    {
     private readonly ApplicationDbContext _db;
       public ComprarModel(ApplicationDbContext db)
       {
            _db= db;
       }
        
        public IList<Subastas> Subastar { get;set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Categoria { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SubastasCategoria { get; set; }
        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _db.Subastas
                                    orderby m.Categoria
                                    select m.Categoria;

    var subastas = from m in _db.Subastas
                 select m;

    if (!string.IsNullOrEmpty(SearchString))
    {
        subastas = subastas.Where(s => s.NombreArticulo.Contains(SearchString));
    }

    if (!string.IsNullOrEmpty(SubastasCategoria))
    {
        subastas = subastas.Where(x => x.Categoria == SubastasCategoria);
    }
    Categoria = new SelectList(await genreQuery.Distinct().ToListAsync());

            Subastar = await _db.Subastas.ToListAsync();
        }
    }
}
