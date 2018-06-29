using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Salon.EF;
using Microsoft.AspNetCore.Cors;

namespace Salon.Api.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [Produces("application/json")]
    [Route("api/Student")]
    public class StudentController : Controller
    {
        // GET: api/Student
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            IEnumerable<Student> lStudents;
            using (var dbContext = new SalonContext())
            {
                lStudents = dbContext.Studens.ToArray();

            }
            return lStudents;
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            Student student;
            using (var dbContext = new SalonContext())
            {
                student = dbContext.Studens.FirstOrDefault(source => source.Id == id);

            }
            return student;
        }
        
        // POST: api/Student
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Student/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
