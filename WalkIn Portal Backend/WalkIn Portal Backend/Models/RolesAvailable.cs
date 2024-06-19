using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class RolesAvailable
{
    public int JobId { get; set; }

    public int JobRolesId { get; set; }

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual Job Job { get; set; } = null!;

    public virtual Role JobRoles { get; set; } = null!;
}
