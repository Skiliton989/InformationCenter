using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InformationCenter.Models.Data
{
    public class CompletedWork
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public short Id { get; set; }

        [Required(ErrorMessage = "Введите дату заявки на работу")]
        [Display(Name = "Дата заявки на работу")]
        public DateTime JobApplicationDate { get; set; }

        [Display(Name = "Дата начало работ")]
        public DateTime DateStartWork { get; set; }

        [Display(Name = "Дата окончание работ")]
        public DateTime? DateEndWork { get; set; }

        [Required]
        public string IdUser { get; set; }

        [Required]
        public short IdServiceСategory { get; set; }

        [Display(Name = "Примечание")]
        public DateTime Note { get; set; }

        [Required(ErrorMessage = "Введите заказчика")]
        [Display(Name = "Заказчик")]
        public string Customer { get; set; }

        [Required(ErrorMessage = "Введите количество")]
        [Display(Name = "Количество")]
        public short Quantity { get; set; }

        [Required]
        public short IdEquipment { get; set; }

        [Required]
        public short IdPlaceOfWork { get; set; }

        //навигационное свойство

        [ForeignKey("IdUser")]
        public User User { get; set; }

        //навигационное свойство

        [ForeignKey("IdServiceСategory")]
        public ServiceСategory ServiceСategory { get; set; }

        //навигационное свойство

        [ForeignKey("IdEquipment")]
        public Equipment Equipment { get; set; }

        //навигационное свойство

        [ForeignKey("IdPlaceOfWork")]
        public PlaceOfWork PlaceOfWork { get; set; }
    }
}
