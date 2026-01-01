using System;
using System.Collections.Generic;

namespace FurOfTheWeak.Models;

public partial class PostDatum
{
    public int PostId { get; set; }

    public DateOnly PostDate { get; set; }

    public int Id { get; set; }

    public virtual UserDatum IdNavigation { get; set; } = null!;
}
