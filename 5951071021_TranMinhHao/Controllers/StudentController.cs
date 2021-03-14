using _5951071021_TranMinhHao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5951071021_TranMinhHao.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var StudentInfList = new List<StudentInfo>();
            for (int i = 0; i < 10; i++)
            {
                var StudentInfo = new StudentInfo
                {
                    Id = i,
                    Name = $"Student {i}",
                    BirdYear = 2000
                };
                StudentInfList.Add(StudentInfo);
            }
            return StudentInfList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                Id = id,
                Name = $"Student {id}",
                BirdYear = 2000
            };
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
