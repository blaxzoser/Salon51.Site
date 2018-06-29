using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Salon.EF
{
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Phone { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }   
        public List<Class> Classes { get; set; }
}
}
