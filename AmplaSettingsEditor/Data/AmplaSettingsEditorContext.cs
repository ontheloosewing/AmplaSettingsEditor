using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AmplaSettingsEditor.Models
{
    public class AmplaSettingsEditorContext : DbContext
    {
        public AmplaSettingsEditorContext (DbContextOptions<AmplaSettingsEditorContext> options)
            : base(options)
        {
        }

        public DbSet<AmplaSettingsEditor.Models.AmplaField> AmplaField { get; set; }
    }
}
