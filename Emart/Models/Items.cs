using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Emart.Models
{
    public class Items:SubCategory
    {
        public Items(int sC_Id, string sCname, int cId, string cname) : base(sC_Id, sCname, cId, cname)
        {
        }

        [Key]
        public int Id { get; set; }
        
        
        
        public int Price { get; set; }
        public string Itemname{get;set;}
        public string IDesc { get; set; }
        public int StockNumber { get; set; }
        public string Remarks { get; set; } 
    }
}
