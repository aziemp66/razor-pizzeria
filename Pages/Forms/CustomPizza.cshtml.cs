using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razor_pizzeria.Pages.Forms
{
    public class CustomPizza : PageModel
    {
        private readonly ILogger<CustomPizza> _logger;

        public CustomPizza(ILogger<CustomPizza> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}