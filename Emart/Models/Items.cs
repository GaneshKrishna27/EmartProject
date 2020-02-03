using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emart.Models
{
    public class Items
    {
        public int Id { get; set; }
        public int C_Id { get; set; }
        public int SC_Id { get; set; }
        public int Price { get; set; }
        public string Itemname{get;set;}
        public string Desc { get; set; }
        public int StockNumber { get; set; }
        public string Remarks { get; set; } 
    }
}
