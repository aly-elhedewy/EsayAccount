using System;
using System.Collections.Generic;

namespace EsayAccount.DAL2
{
    public partial class UnitName
    {
        public UnitName()
        {
            UnitProduct = new HashSet<UnitProduct>();
        }

        public int IdUnit { get; set; }
        public int CodeUnit { get; set; }
        public string NameUnit { get; set; }

        public ICollection<UnitProduct> UnitProduct { get; set; }
    }
}
