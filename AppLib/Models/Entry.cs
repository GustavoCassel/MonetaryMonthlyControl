namespace AppLib.Models;

public partial class Entry
{
    public Guid Id { get; set; }

    public Guid Category { get; set; }

    public string? Description { get; set; }

    public decimal Amount { get; set; }

    public DateTime Created { get; set; }

    public DateTime? Modified { get; set; }

    public virtual Category CategoryNavigation { get; set; } = null!;
}
