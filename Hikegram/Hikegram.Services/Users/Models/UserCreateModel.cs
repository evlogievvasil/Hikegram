namespace Hikegram.Services.Users.Models
{
  public class UserCreateModel
  {
    public string UserName { get; set; }

    public string NormalizedUserName { get; set; }

    public string Email { get; set; }

    public string NormalizedEmail { get; set; }

    public string Password { get; set; }

    public string PhoneNumber { get; set; }
  }
}
