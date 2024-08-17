namespace WayniApi.Models;

public class UpdatePasswordItem
{
    public required string CurrentPassword { get; set; }

    public required string Password { get; set; }

    public required string PasswordConfirmation { get; set; }
}