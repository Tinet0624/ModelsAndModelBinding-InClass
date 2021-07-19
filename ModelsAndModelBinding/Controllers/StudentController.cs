using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsAndModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Controllers
{
    public class StudentController : Controller
    {
        //user goes to page
        [HttpGet] //Atribute for methods this one is default *get shows it in the URL
        public IActionResult Add()
        {
            return View();
        }

        //sending data to a server
        [HttpPost] // After user posts form data
        public IActionResult Add(IFormCollection form)
        {
            Student stu = new Student() 
            { 
                FullName = form["full-name"],
                DateOfBirth = Convert.ToDateTime(form["dob"]),
                Email = form["email"],
                PhoneNumber = form["phone-number"]
            };
            
            return View();
        }
    }
}
