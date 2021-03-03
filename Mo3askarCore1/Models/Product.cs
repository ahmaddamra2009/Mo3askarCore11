using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mo3askarCore1.Models
{
    // Code First ( Entity FWCore)
    public class Product
    {

        /// <summary>
        /// Id >> Primary Key + Identity
        /// </summary>
        /// [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter Product Name")]
        [MinLength(4,ErrorMessage ="Product name g.t 4 char")]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        [Range(100,1000,ErrorMessage ="price between 100 - 1000")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Enter Qty ")]
        public int Qty { get; set; }

    }
}
