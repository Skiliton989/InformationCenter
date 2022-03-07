using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformationCenter.Models.Data
{
    public class ServiceСategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public short Id { get; set; }

        [Required(ErrorMessage = "Введите название")]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Услуги")]
        public short IdService { get; set; }
        //навигационное свойство

        [ForeignKey("IdService")]
        public Service Service { get; set; }

        [Required]
        public ICollection<CompletedWork> CompletedWorks { get; set; }
    }
}
