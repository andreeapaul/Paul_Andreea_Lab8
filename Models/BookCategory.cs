using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paul_Andreea_Lab8.Models
{
    public class BookCategory
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public int BookID { get; set; }
        public Book Book { get; set; }
      
        [Display(Name = "Category Name")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
