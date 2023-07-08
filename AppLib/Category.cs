using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection;

namespace AppLib;

/*
 internal
 public
 private
 protected
 */

public record Teste();


[PrimaryKey(nameof(Id))]
public sealed class Category
{
    public Guid Id { get; }

    [Required, MaxLength(100)]
    public string? Name { get; }

    public string? Description { get; }

    [Required]
    public DateTime Created { get; }
    public DateTime Modified { get; }

    public Category()
    {
        Id = Guid.NewGuid();
        Name = "Nome Teste";
        Description = "Descrição Teste";
        Created = DateTime.Now;

        /*
        Id = (Guid)dataRow["Id"];

        Name = dataRow["Name"].ToString()
               ?? throw new ArgumentNullException(nameof(Name), $"The '{nameof(Name)}' column was null!");

        Description = dataRow["Description"].ToString()
               ?? throw new ArgumentNullException(nameof(Description), $"The '{nameof(Description)}' column was null!");

        Created = DateTime.Parse(dataRow["Created"].ToString());

        Modified = dataRow["Modified"].ToString() is null ?
            default :
            DateTime.Parse(dataRow["Modified"].ToString().AsSpan());
        */
    }

    /*
        Id
        2353ab31-a4da-42a3-bb8d-85ce9e2ac983
        Name
        Bebida
        Description
        Bebida do fim de semana
        Created
        12/06/2023 21:21:43
        Modified
    */
}