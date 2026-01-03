using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Data;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDBContext _dbContext;

        public StudentController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //register  a page
        public IActionResult AddStudent() => View();

        //add astudent to admin panel
        public IActionResult AddStudentToDB() => View("AddStudent");

        //main page
        public IActionResult Index()
        {
            var dbData = _dbContext.StudentsDB.ToList();
            return View(dbData);
        }

        [HttpPost]
        public IActionResult RegisterAStudent(string studentName,  int studentAge, string studentEmail, string department)
        {
            var newStudent = new Students
            {
                Name = studentName,
                Age = studentAge,
                Email = studentEmail,
                Department = department
            };

            //check student already registered
            var studentExists = _dbContext.StudentsDB.FirstOrDefault(s => s.Email == studentEmail);
            if (studentExists !=null)
            {
                return View("UserAlreadyExits");
            }
            //if not save student
            _dbContext.StudentsDB.Add(newStudent);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        //search a student
        public IActionResult SearchAStudent(string searchAStudentName)
        {
            var student = _dbContext.StudentsDB.Where(s=> s.Name.Contains(searchAStudentName)).ToList();
            return View(student);
        }

        //delete a student
        public IActionResult DeleteAStudent(int delStudentId)
        {
            var student = _dbContext.StudentsDB.FirstOrDefault(s => s.StudentId == delStudentId);
            if(student == null)
            {
                return View("UserAlreadyExits");
            }
            _dbContext.StudentsDB.Remove(student);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult UpdateAStudent(int updateStudentId)
        {
            var student = _dbContext.StudentsDB.FirstOrDefault(s => s.StudentId == updateStudentId);
            return View(student);
        }

        public IActionResult UpdateStudentDB(int updStudentId, string studentName, int studentAge, string studentEmail, string department)
        {
            var dbData = _dbContext.StudentsDB.FirstOrDefault(s => s.StudentId == updStudentId);
            if (dbData == null) { return NotFound(); }

            dbData.Name = studentName;
            dbData.Age = studentAge;
            dbData.Email = studentEmail;
            dbData.Department = department;

            _dbContext.StudentsDB.Update(dbData);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        
    }
}
