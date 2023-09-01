using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razor_pizzeria.Pages
{
    public class Pizza : PageModel
    {
        private readonly ILogger<Pizza> _logger;

        public Pizza(ILogger<Pizza> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}