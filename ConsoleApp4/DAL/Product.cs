using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.DAL
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [Column("ProductName")]
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual Category Category { get; set; }
    }
}
