using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.EF
{
    public class Subscription
    {
        [Key]
        public int SubscriptionID { get; set; }
        public DateTime Register { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("Class")]
        public int ClassID { get; set; }
        public Class Class { get; set; }

        [ForeignKey("Student")]
        public int StudenID  { get; set; }
        public Student Student { get; set; }

        

    }
}
