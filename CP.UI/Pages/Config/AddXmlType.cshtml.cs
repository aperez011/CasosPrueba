using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CP.Entity;
using CP.Services;
using Microsoft.Extensions.Logging;
using CP.Core.Interfaces;

namespace CP.UI
{
    public class AddXmlTypeModel : PageModel
    {
        private readonly ILogger<AddXmlTypeModel> _logger;
        private readonly ISectionServices _sectionServices;
        public List<Section> Sections { get; set; }
        [BindProperty]
        public Section Section { get; set; }

        public AddXmlTypeModel(ILogger<AddXmlTypeModel> logger, ISectionServices sectionServices)
        {
            _logger = logger;
            _sectionServices = sectionServices;
        }

        public void OnGet()
        {
            this.SetValue();
        }

        public async Task<IActionResult> OnPostAddSection()
        {
            if (!ModelState.IsValid) return Page();

            //Save section
            await _sectionServices.Insert(Section);

            this.SetValue();
            return Page();
        }


        public void OnPostTest(string Name)
        {
            this.SetValue();
            Sections.Add(Section);
        }

        private void SetValue()
        {
            var data = _sectionServices.GetAll();
            Sections = data.ToList();
        }
    }
}