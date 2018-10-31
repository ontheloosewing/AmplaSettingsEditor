using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AmplaSettingsEditor.Models
{
    public class IndexModel : PageModel
    {
        private readonly AmplaSettingsEditor.Models.AmplaSettingsEditorContext _context;

        public IndexModel(AmplaSettingsEditor.Models.AmplaSettingsEditorContext context)
        {
            _context = context;
        }

        public IList<AmplaField> AmplaField { get;set; }

        public async Task OnGetAsync()
        {
            AmplaField = await _context.AmplaField.ToListAsync();
        }
    }
}
