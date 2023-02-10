using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aplication.DTOs
{
    public class ProductVw
    {  
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(100, MinimumLength = 3)]
        [Display(Description = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString ="{0:C2}")]
        [Display(Name ="Price")]
        public string Price { get; set; }

        [Required(ErrorMessage = "Stock is required")]
        [Range(1, 99999)]
        [Display(Name = "Stock")]
        public string Stock { get; set; }

        [Required(ErrorMessage = "Image is required")]
        [StringLength(250)]
        [Display(Name = "Image")]
        public string Image { get; set; }

        [Display(Name = "Categories")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
