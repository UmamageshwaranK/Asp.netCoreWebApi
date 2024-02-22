using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactAspCrud.Models;
using System.Runtime.InteropServices;

namespace ReactAspCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentControler : ControllerBase
    {

private readonly StudentDBContext _studentDbContext; // first get the DataBase Context we are use this object in this class only then only put the readonly
       

        public StudentControler(StudentDBContext studentDBContext)
        {
           _studentDbContext = studentDBContext;   // use  this constructor   use the student DBContext
        }
        [HttpGet]  //What request  you want 
        [Route("GetStudent")]   
        public async Task<IEnumerable<students>> GetStudents()
        {
            return await _studentDbContext.students.
                ToListAsync();
                }
        [HttpPost]
        [Route("AddStudent")]
        public async Task<students> Addstudents(students objstudent)
        {
            _studentDbContext.students.Add(objstudent);
            await _studentDbContext.SaveChangesAsync();
            return objstudent;
        }
        [HttpPatch]
        [Route("UpdateStudent/(id)")]

        public async Task <students>UpdateStudent(students objstudent)
        {
            _studentDbContext.Entry(objstudent).State = EntityState.Modified;
            await _studentDbContext.SaveChangesAsync();
            return objstudent;
        }
        [HttpPatch]
        [Route("DeleteStudent/(id)")]
         public bool DeleteStudent(int id)
        {
            bool a  = false;
            var student = _studentDbContext.students.Find(id);
            if (student != null)
            {
                a = true;
                _studentDbContext.Entry(student).State = EntityState.Deleted;
                _studentDbContext.SaveChanges();
            }
            else
            {
                a = false;
            }
            return a;
        }
    }
}
