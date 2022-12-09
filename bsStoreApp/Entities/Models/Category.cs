using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String? CategoryName { get; set; }

        // Ref : Collection navigation property
        //public ICollection<Book> Books { get; set; }
    }
}
