using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InformationCenter.Models.Data
{
    public class Equipment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public short Id { get; set; }

        [Required(ErrorMessage = "Введите название")]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Номер")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Введите дату ввода в эксплуатацию")]
        [Display(Name = "Дата ввода в эксплуатацию")]
        public DateTime CommissioningDate { get; set; }

        [Display(Name = "Дата списания")]
        public DateTime? DateOfWriteOff {get; set; }

        [Required]
        public ICollection<StatusOfEquipment> StatusesOfEquipment { get; set; }
        
        [Required]
        public ICollection<CompletedWork> CompletedWorks { get; set; }
    }
}
