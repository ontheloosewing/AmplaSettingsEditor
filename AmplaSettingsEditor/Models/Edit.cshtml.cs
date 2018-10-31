using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AmplaSettingsEditor.Models
{
    public class EditModel : PageModel
    {
        private readonly AmplaSettingsEditor.Models.AmplaSettingsEditorContext _context;

        public EditModel(AmplaSettingsEditor.Models.AmplaSettingsEditorContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AmplaField).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmplaFieldExists(AmplaField.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AmplaFieldExists(int id)
        {
            return _context.AmplaField.Any(e => e.Id == id);
        }
    }
}
