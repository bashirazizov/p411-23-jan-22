using Datatofront.DAL;
using Datatofront.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datatofront.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext innerdb;
        public StudentController(AppDbContext _db)
        {
            innerdb = _db;
        }

        public IActionResult Index()
        {
            return View(innerdb.Students);
        }

        public IActionResult Info(int id)
        {
            Student stu = innerdb.Students.FirstOrDefault(x => x.Id == id);
            if (stu == null)
            {
                TempData["error"] = "Student does not exist.";
            }
            return View(stu);
        }

        //List<Student> students = new List<Student>
        //{
        //    new Student(1, "Mamed", "Aliyev", 11, "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1e/Mamed_Chalidow.JPG/330px-Mamed_Chalidow.JPG"),
        //    new Student(2, "Barack", "Obama", 56, "https://www.biography.com/.image/t_share/MTE4MDAzNDEwNzg5ODI4MTEw/barack-obama-12782369-1-402.jpg"),
        //    new Student(3, "Vladimir", "Putin", 70, "https://m.media-amazon.com/images/I/61qzcEfU3aL._AC_SX466_.jpg"),
        //    new Student(4, "Mehemmed", "Alisoy", 11, "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1e/Mamed_Chalidow.JPG/330px-Mamed_Chalidow.JPG"),
        //    new Student(5, "Fezail", "Qezenferov", 56, "https://www.biography.com/.image/t_share/MTE4MDAzNDEwNzg5ODI4MTEw/barack-obama-12782369-1-402.jpg"),
        //    new Student(6, "Vladimir", "Lenin", 70, "https://m.media-amazon.com/images/I/61qzcEfU3aL._AC_SX466_.jpg"),
        //};

        //Student st = students.Find(x=>x.Id == id);

        //if (st == null)
        //{
        //    TempData["error"] = "Student does not exist.";
        //}

    }
}
