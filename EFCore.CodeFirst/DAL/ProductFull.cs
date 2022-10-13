using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.DAL
{
    [Keyless] //burada eklemek yerine appdbcontext içinde onmodelcreatinde belirtebiliriz fakat burada eklemek daha bestpractice olucaktır.
    public class ProductFull
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Height { get; set; }
    }
}
