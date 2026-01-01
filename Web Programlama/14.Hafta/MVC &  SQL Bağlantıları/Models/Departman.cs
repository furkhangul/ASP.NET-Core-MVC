using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Departman
{
    public int DeptId { get; set; }

    public string DeptName { get; set; } = null!;

    public int DeptCapasity { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
