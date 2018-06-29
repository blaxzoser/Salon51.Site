using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Salon.EF
{
    public static class DbInitializer
    {
        public static void Initialize(SalonContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Studens.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{Name="Luis Pintado", Age=28, Email="strato.beto@gmail.com", From="Ciudad de Mexico", Phone=55345318, Register= "13-01-2018",TypePublicity="Facebook"},
            new Student{Name="Myriam Soltero", Age=27, Email="hermosa.beto@gmail.com", From="Chihuhua", Phone=33345318, Register= "13-01-2018",TypePublicity="Sociales"},
            new Student{Name="Erick Lopez", Age=10, Email="erik.lopez@gmail.com", From="Guadalajara", Phone=33345318, Register= "13-01-2018",TypePublicity="Amigos"},
            new Student{Name="Danny Mora", Age=10, Email="danny.mora@gmail.com", From="Guadalajara", Phone=33345318, Register= "13-01-2018",TypePublicity="Youtube"}
            };
            foreach (Student s in students)
            {
                context.Studens.Add(s);
            }
            context.SaveChanges();
        }
    }
}
