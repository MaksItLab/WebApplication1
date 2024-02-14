using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		private static readonly List<Employee> _employees = new()
		{
			new Employee{ID = 1, FirstName = "Jonh", LastName = "Reboot", Patronymic = "Noogvre", Age = 34 },
			new Employee{ID = 2, FirstName = "Rett", LastName = "Dewor", Patronymic = "Farenier", Age = 16 },
			new Employee{ID = 3, FirstName = "Bettir", LastName = "Mertynol", Patronymic = "Bertyop", Age = 20 },
		};

		public IActionResult Index()
		{
			return View();
		}

		public string ShowStr([FromQuery]string a)
		{
			return $"HI! {a}";
		}

		public IActionResult Employees() {
			return View(_employees);
		}
	}
}
