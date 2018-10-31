using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AmplaSettingsEditor.Models;

namespace AmplaSettingsEditor.Pages.AmplaFields
{
    public class IndexModel : PageModel
    {
        private readonly AmplaSettingsEditor.Models.AmplaSettingsEditorContext _context;

        public IndexModel(AmplaSettingsEditor.Models.AmplaSettingsEditorContext context)
        {
            _context = context;
        }

        public IList<AmplaField> AmplaField { get;set; }

        public async Task OnGetAsync(string searchString)
        {
            var amplaFields = from m in _context.AmplaField
                              select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                amplaFields = amplaFields.Where(s => s.Name.Contains(searchString));
            }
            AmplaField = await amplaFields.ToListAsync();
        }
    }
}
