using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Lasmart.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PointId { get; set; }
        public Point Point { get; set; }
        
        public string Text { get; set; }
        public string BackgroundColor { get; set; }
    }
}
