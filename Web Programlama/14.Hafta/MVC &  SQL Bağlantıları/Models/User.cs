using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Code { get; set; }

    public int DeptId { get; set; }

    public virtual Departman Dept { get; set; } = null!;
}
