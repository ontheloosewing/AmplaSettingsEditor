using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmplaSettingsEditor.Models
{
    public class AmplaField
    {
        public int Id { get; set; }

        [Display(Name = "Имя системное")]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        [Display(Name = "Имя отображамое EN")]
        [Column(TypeName = "nvarchar(200)")]
        public string NameEnglish { get; set; }

        [Display(Name = "Имя отображамое RU")]
        [Column(TypeName = "nvarchar(200)")]
        public string NameRussian { get; set; }

        [Display(Name = "Имя полное")]
        [Column(TypeName = "nvarchar(max)")]
        public string NameFull { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Display(Name = "Репорт поинт Id")]
        public int RpId { get; set; }

        [Display(Name = "Репорт поинт полное имя")]
        [Column(TypeName = "nvarchar(max)")]
        public string RpNameFull { get; set; }

        [Display(Name = "Репорт поинт тип")]
        public string RpType { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9]*$")]
        [Required]
        [Display(Name = "SAP Id")]
        [Column(TypeName = "nvarchar(200)")]
        public string SapId { get; set; }

        [Display(Name = "Создано когда")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Создано кем")]
        [Column(TypeName = "nvarchar(200)")]
        public string CreatedBy { get; set; }
    }
}
