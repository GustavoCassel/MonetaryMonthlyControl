using System.Data;
using System.Numerics;

namespace AppLib;

/*
 internal
 public
 private
 protected
 */

internal sealed class Category
{
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public DateTime Created { get; }
    public DateTime Modified { get; }

    public Category(DataRow dataRow)
    {
        Id = (Guid)dataRow["Id"];

        Name = dataRow["Name"].ToString()
               ?? throw new ArgumentNullException(nameof(Name), $"The '{nameof(Name)}' column was null!");
        Description = dataRow["Description"].ToString()
               ?? throw new ArgumentNullException(nameof(Description), $"The '{nameof(Description)}' column was null!");

        Created = DateTime.Parse(dataRow["Created"].ToString() ?? default);
        Modified = dataRow["Modified"].ToString() is null ?
            default :
            DateTime.Parse(dataRow["Modified"].ToString());
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