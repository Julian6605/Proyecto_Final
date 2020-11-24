using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace WebApp1.Pages
{
    public class InformacionModel : PageModel
    {
        private readonly ILogger<InformacionModel> _logger;

        public InformacionModel(ILogger<InformacionModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
