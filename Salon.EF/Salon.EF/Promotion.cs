using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Salon.EF
{
    public class Promotion
    {
        [Key]
        public int PromotionID { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public DateTime Register { get; set; }
        public decimal Cost { get; set; }
        public int Percent { get; set; }
        public DateTime Until { get; set; }
        public bool IsActive { get; set; }

    }
}
