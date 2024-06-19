using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class Login
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int UserDetailsUserId { get; set; }

    //public DateTime? DtCreated { get; set; }

    //public DateTime? DtModified { get; set; }

    //public virtual UserDetail UserDetailsUser { get; set; } = null!;
}
