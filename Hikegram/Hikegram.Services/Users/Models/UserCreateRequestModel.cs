using System.ComponentModel.DataAnnotations;

namespace Hikegram.Services.Users.Models
{
  public class UserCreateRequestModel
  {
    [Required(ErrorMessage = "Потребителското име е задължително.")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "Имейлът е задължителен.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Паролата е задължителна.")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Потвърждението на паролата е задължително.")]
    public string ConfirmPassword { get; set; }
    
    // TODO: add regex check
    public string PhoneNumber { get; set; }

    // TODO: two factor authentication
  }
}
