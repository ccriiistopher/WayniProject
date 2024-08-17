namespace WayniApi.Models;

public class UserItem
{
    public long Id { get; set; }
    public required string Name { get; set; }

    public required string Username { get; set; }

    public required string Email { get; set; }

    public required string Phone { get; set; }

    public required string Password { get; set; }


}

public class UserItemOptional
{
    public string? Name { get; set; }

    public string? Username { get; set; }



}