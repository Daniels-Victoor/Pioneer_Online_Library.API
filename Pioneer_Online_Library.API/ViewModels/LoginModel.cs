using System.ComponentModel.DataAnnotations;

namespace Pioneer_Online_Library.API.ViewModels
{

	public class LoginModel
	{
		[Required(ErrorMessage = "Please enter your User Name")]
		public string UserName { get; set; } = null!;

		[Required(ErrorMessage = "Please enter your Password")]
		public string Password { get; set; } = null!;
	}
}
