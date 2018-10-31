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
    public class DeleteModel : PageModel
    {
        private readonly AmplaSettingsEditor.Models.AmplaSettingsEditorContext _context;

        public DeleteModel(AmplaSettingsEditor.Models.AmplaSettingsEditorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AmplaField AmplaField { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AmplaField = await _context.AmplaField.FirstOrDefaultAsync(m => m.Id == id);

            if (AmplaField == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AmplaField = await _context.AmplaField.FindAsync(id);

            if (AmplaField != null)
            {
                _context.AmplaField.Remove(AmplaField);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
