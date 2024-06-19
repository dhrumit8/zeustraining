using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class JobRole
{
    public int Id { get; set; }

    public string Roles { get; set; } = null!;

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual ICollection<UserHasJobRole> UserHasJobRoles { get; } = new List<UserHasJobRole>();
}
