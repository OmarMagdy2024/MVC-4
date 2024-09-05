using Microsoft.AspNetCore.Mvc;
using MVC_4_BLL.InterFaces;
using MVC_4_BLL.Repositorys;

namespace MVC_4_PL.Controllers
{
    public class DepartmentController1 : Controller
    {
        private readonly IDepartmentRepository _departmentrepository;
        public DepartmentController1(IDepartmentRepository departmentRepository)
        {
            _departmentrepository = departmentRepository;
        }
        public IActionResult Index()
        {
            _departmentrepository.GetAll();
            return View();
        }
    }
}
