using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Image1 { get; set; }
        public String Title2 { get; set; }
        public String Description2 { get; set; }
        public bool Status { get; set; }
    }
}
