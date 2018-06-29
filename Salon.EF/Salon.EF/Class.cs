using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Salon.EF
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public string Schedule { get; set; }
        public decimal? MounthCost { get; set; }
        public decimal? IndividualCost { get; set; }
        public decimal? TotalCost { get; set; }
        public int TypeClass { get; set; }
        public bool Mon { get; set; }
        public bool Tue { get; set; }
        public bool Wen { get; set; }
        public bool Thu { get; set; }
        public bool Fri { get; set; }
        public bool Sat { get; set; }
        public bool Sun { get; set; }
    }
}
