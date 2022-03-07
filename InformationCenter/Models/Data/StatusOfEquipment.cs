using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformationCenter.Models.Data
{
    public class StatusOfEquipment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public short Id { get; set; }

        [Required]
        public string IdUser { get; set; }

        [Required]
        public short IdStaus { get; set; }

        [Required(ErrorMessage = "Введите дату")]
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
        
        [Required]
        public short IdEquipment { get; set; }

        //навигационное свойство

        [ForeignKey("IdUser")]
        public User User { get; set; }

        [ForeignKey("IdStatus")]
        public Status Status { get; set; }

        [ForeignKey("IdEquipment ")]
        public Equipment Equipment { get; set; }
    }
}
