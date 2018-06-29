using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Salon.EF
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int Age { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        public string Register { get; set; }

        [Required]
        public int Phone { get; set; }
        public string TypePublicity { get; set; }
        public string From { get; set; }

        [Required]
        public DateTime Birthday { get; set; }
    }
}
