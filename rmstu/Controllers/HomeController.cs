using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using rmstu.Models;
using rmstu.viewModel;

namespace rmstu.Controllers
{
    public class HomeController : Controller
    {

        new List<Department> department = new List<Department>()
        { 
            new Department{Id =1,Name ="CSE"},
            new Department{Id = 2,Name = "MGT"},
            new Department{Id =3 ,Name="THM"},
            new Department{Id=4 ,Name= "FES"},
            new Department{Id=5 ,Name="FMRT"}
        };


        public IActionResult Index()
        {
             viewModelClass vm = new viewModelClass()
            { 
                Departments = department
            
            };

            return View(vm);
        }

       

        
    }
}
