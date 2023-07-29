using Bogus;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AppLib;

[PrimaryKey(nameof(Id))]
public sealed class Category
{
    public Guid Id { get; }

    [Required, MaxLength(100)]
    public string Name { get; }

    [Required, MaxLength(100)]
    public string Description { get; }

    [Required]
    public DateTime Created { get; }
    public DateTime Modified { get; }

    public Category()
    {
        Id = Guid.NewGuid();

        Faker faker = new();
        Name = faker.Person.FullName;
        Description = faker.Lorem.Text();
        Created = DateTime.Now;
    }

    /*
        Id - 2353ab31-a4da-42a3-bb8d-85ce9e2ac983
        Name - Bebida
        Description - Bebida do fim de semana
        Created - 12/06/2023 21:21:43
        Modified - 
    */
}