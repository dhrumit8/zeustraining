using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class UserAppliedForJobHasRolesPreference
{
    public int UserId { get; set; }

    public int JobId { get; set; }

    public int RolesId { get; set; }

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual Role Roles { get; set; } = null!;

    public virtual UserAppliedForJob UserAppliedForJob { get; set; } = null!;
}
