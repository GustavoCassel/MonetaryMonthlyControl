namespace AppWeb.Models;

public class Person
{
    public int Id { get; set; }
    public int Age { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
}