using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.EF
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Required]
        public int TypeCost { get; set; }
        public DateTime Register { get; set; }
        public decimal? Cost { get; set; }
        public decimal? CostTotal { get; set; }

        public int PromotionID { get; set; }
        public Promotion Promotion { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }
    }
}
