using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Roles { get; set; } = null!;

    public int RolesDetailId { get; set; }

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual ICollection<RolesAvailable> RolesAvailables { get; } = new List<RolesAvailable>();

    public virtual RolesDetail RolesDetail { get; set; } = null!;

    public virtual ICollection<UserAppliedForJobHasRolesPreference> UserAppliedForJobHasRolesPreferences { get; } = new List<UserAppliedForJobHasRolesPreference>();
}
