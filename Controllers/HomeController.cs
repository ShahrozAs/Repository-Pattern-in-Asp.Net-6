using Microsoft.AspNetCore.Mvc;
using PracticeView.Models;
using PracticeView.Repositry;
using System.Diagnostics;

namespace PracticeView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository=null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository=new StudentRepository();
        }

        public List<StudentModel> getAllStudents()
        {
            return _studentRepository.getAllStudents();
        }

        public StudentModel getStudentById(int id) {
            return _studentRepository.getStudentByID(id);
        }
        public IActionResult Index()
        {
            ViewData["student"] = new List<StudentModel>{
            new StudentModel{rollNo=1,Name="Shehroz Ashraf",Gender="Male",standard=16},
            new StudentModel{rollNo=2,Name="Ali Arif",Gender="Male",standard=15},
            new StudentModel{rollNo=3,Name="Bilal Doger",Gender="Male",standard=14}
            };
            
            return View();

        }

        public IActionResult About()
        {
         
            return View();
        }   
        public IActionResult Contact()
        {
            return View();
        }   
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
