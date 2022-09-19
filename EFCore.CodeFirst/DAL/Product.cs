using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.DAL
{
    [Table("ProductTb",Schema ="products")]
    public class Product
    {
        //[Column(Order = 1)]
        public int Id { get; set; }
        // [Column("name2",Order =2)]
        //nulable açık ise nullable:false
        //[MaxLength(100)]
        //fluent validation
       // [StringLength(100,MinimumLength =50)]
        public string Name { get; set; }
        //[Column("price2", Order = 2,TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int Barcode { get; set; }
        //ekstra bişey belirtmeden foreignkey olarak algılıyor bu şekilde isimle
        public int Category_Id { get; set; }
        [ForeignKey("Category_Id")]
        public Category Category { get; set; }
    }
}
