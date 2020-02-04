using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Emart.Models
{
    public class SubCategory:Category
    {
        public SubCategory(int sC_Id, string sCname, int cId, string cname)
        {
            SC_Id = sC_Id;
            SCname = sCname;
            CId = cId;
            Cname = cname;
        }

        [Key]
        public int SC_Id { get; set; }
        public string SCname { get; set; }
        
        public string SCDesc { get; set; }
        public double Gstin { get; set; }

    }
}
