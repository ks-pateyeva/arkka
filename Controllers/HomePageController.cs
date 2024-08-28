using Microsoft.AspNetCore.Mvc;

namespace arkka.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class HomePageController : ControllerBase
	{
		private readonly ILogger<HomePageController> _logger;

		public HomePageController(ILogger<HomePageController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public List<int> Get()
		{
			return new List<int>();
		}
	}
}