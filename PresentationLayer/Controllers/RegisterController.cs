using DtoLayer.Dtos.AppUserDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		public RegisterController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(CreateAppUserDto createAppUserDto)
		{
			if(ModelState.IsValid)
			{
				AppUser appUser = new AppUser()
				{
					UserName = createAppUserDto.UserName,
					Email = createAppUserDto.Email,
					FirstName = createAppUserDto.FirstName,
					LastName = createAppUserDto.LastName,
				};

				var result = await _userManager.CreateAsync(appUser,createAppUserDto.Password);

				if(result.Succeeded)
				{
					return RedirectToAction("Index", "ConfirmMail");
				}
				else
				{
					foreach(var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}

			return View();
			
		}
	}
}
