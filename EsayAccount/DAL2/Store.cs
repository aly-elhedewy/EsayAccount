using System;
using System.Collections.Generic;

namespace EsayAccount.DAL2
{
    public partial class Store
    {
        public Store()
        {
            InvoiceDetalies = new HashSet<InvoiceDetalies>();
            Product = new HashSet<Product>();
        }

        public int IdStore { get; set; }
        public int CodeStore { get; set; }
        public string NameStore { get; set; }
        public int? BranchCode { get; set; }

        public Branch BranchCodeNavigation { get; set; }
        public ICollection<InvoiceDetalies> InvoiceDetalies { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
