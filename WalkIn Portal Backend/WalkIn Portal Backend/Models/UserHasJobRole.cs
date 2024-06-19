using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class UserHasJobRole
{
    public int UserDetailsUserId { get; set; }

    public int JobRolesId { get; set; }

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual JobRole JobRoles { get; set; } = null!;

    public virtual UserDetail UserDetailsUser { get; set; } = null!;
}
