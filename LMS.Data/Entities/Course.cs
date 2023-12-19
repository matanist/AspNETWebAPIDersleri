using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Entities
{
    public class Course: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? TeacherId { get; set; }
        public User Teacher { get; set; }
        
    }
}
