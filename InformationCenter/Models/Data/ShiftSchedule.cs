using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InformationCenter.Models.Data
{
    public class ShiftSchedule 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public short Id { get; set; }

        [Required(ErrorMessage = "Введите начала работы")]
        [Display(Name = "Начала работы")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Конец работы")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Отметка о выходе")]
        public bool? ExitMark { get; set; }

        [Display(Name = "Полная смена")]
        public bool? FullChange { get; set; }

        [Required]
        public string IdUser { get; set; }

        //навигационное свойство

        [ForeignKey("IdUser")]
        public User User { get; set; }
    } 
}
