using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformationCenter.Models.Data
{
    public class Price
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public short Id { get; set; }

        [Required]
        public short IdService {get; set;}

        [Required(ErrorMessage = "Введите цену")]
        [Display(Name = "Цена")]
        public decimal Price1 { get; set; }

        [Required(ErrorMessage = "Введите дату установки цен")]
        [Display(Name = "Дата установки цен")]
        public DateTime DateOfPrice { get; set; }

        //навигационное свойство

        [ForeignKey("IdService")]
        public Service Service { get; set; }
    }
}
