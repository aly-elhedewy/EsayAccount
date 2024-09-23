using System;
using System.Collections.Generic;

namespace EsayAccount.DAL2
{
    public partial class Branch
    {
        public Branch()
        {
            Invoice = new HashSet<Invoice>();
            Product = new HashSet<Product>();
            Store = new HashSet<Store>();
            Users = new HashSet<Users>();
        }

        public int IdBranch { get; set; }
        public int CodeBranch { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }

        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<Store> Store { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
