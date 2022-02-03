using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FilmCollection.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int category_id { get; set; }
        public string category_name { get; set; }
    }
}
