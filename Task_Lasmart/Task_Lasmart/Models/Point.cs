using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Lasmart.Models
{
    public class Point
    {
        public int Id { get; set; }
        public int Ox { get; set; }
        public int Oy { get; set; }
        public int Radius { get; set; }
        public string Colour { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


    }
}
