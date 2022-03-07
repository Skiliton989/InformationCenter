using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformationCenter.Models.Data
{
    public class PlaceOfWork
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public short Id { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Введите номер кабинета")]
        [Display(Name = "Номер кабинета")]
        public string NumberRoom { get; set; }

        [Required]
        public ICollection<PlaceOfWork> PlaceOfWorks { get; set; }
    }
}
