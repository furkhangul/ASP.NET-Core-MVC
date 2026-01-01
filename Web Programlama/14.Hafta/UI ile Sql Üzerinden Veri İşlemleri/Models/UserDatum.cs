using System;
using System.Collections.Generic;

namespace FurOfTheWeak.Models;

public partial class UserDatum
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public virtual ICollection<PostDatum> PostData { get; set; } = new List<PostDatum>();
}
