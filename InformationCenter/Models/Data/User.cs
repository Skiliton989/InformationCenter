using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InformationCenter.Models.Data
{
    public class User : IdentityUser
    {
        //дополнительные поля для каждого пользователя
        [Required(ErrorMessage = "Введите фамилию")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введите отчество")]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Required(ErrorMessage = "Введите дату приема")]
        [Display(Name = "Дата приема")]
        public DateTime? DateOfReceipt { get; set; }

        [Display(Name = "Дата увольнения")]
        public DateTime? DateOfDismissal { get; set; }

        [Required]
        public ICollection<ShiftSchedule> ShiftsSchedule { get; set; }

        [Required]
        public ICollection<StatusOfEquipment> StatusesOfEquipment { get; set; }
    }
}
