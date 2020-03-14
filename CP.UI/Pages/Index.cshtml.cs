using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CP.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CP.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IXmlTypeServices _xmlServices;

        public IndexModel(ILogger<IndexModel> logger, IXmlTypeServices xmlType)
        {
            _logger = logger;
            _xmlServices = xmlType;
        }

        public void OnGet()
        {
            var test = 1;
        }

        public void OnPostTestMethod()
        {
            _xmlServices.GetAll();
        }
    }
}
