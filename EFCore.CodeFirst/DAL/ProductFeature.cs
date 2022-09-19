using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.DAL
{
    public class ProductFeature
    {
        [ForeignKey("Product")]
        public int Id { get; set; }//ıd hem Pk hemde Fk olarak kullanıcaz. Best practice
        public int Width { get; set; }
        public int Height { get; set; }
        public string Color { get; set; }
        //public int ProductId { get; set; }//ıd hem Pk hemde Fk olarak kullanıcaz. Best practice
        //public int ProductRef_Id { get; set; }
        //[ForeignKey("ProductRef_Id")]
        public Product Product { get; set; }



    }
}
