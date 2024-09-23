using System;
using System.Collections.Generic;

namespace EsayAccount.DAL2
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int IdCategory { get; set; }
        public int CodeCategory { get; set; }
        public string NameCategory { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
