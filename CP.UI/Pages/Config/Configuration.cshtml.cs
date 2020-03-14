using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CP.UI
{
    public class ConfigurationModel : PageModel
    {
        private readonly ILogger<ConfigurationModel> _logger;

        public ConfigurationModel(ILogger<ConfigurationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}