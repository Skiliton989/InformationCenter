using System;
using System.ComponentModel.DataAnnotations;

namespace InformationCenter.ViewModels.ShiftsSchedule
{
    public class CreateShiftScheduleViewModel
    {
        [Required(ErrorMessage = "Введите начала работы")]
        [Display(Name = "Начала работы")]
        public DateTime? StartDate { get; set; } 

        [Display(Name = "Отметка о выходе")]
        public bool? ExitMark { get; set; }

        [Display(Name = "Полная смена")]
        public bool? FullChange { get; set; }
    }
}
