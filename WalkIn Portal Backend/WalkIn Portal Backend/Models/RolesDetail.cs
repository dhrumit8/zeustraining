using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class RolesDetail
{
    public int Id { get; set; }

    public int GrossPackage { get; set; }

    public string RoleDescription { get; set; } = null!;

    public string Requirements { get; set; } = null!;

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual ICollection<Role> Roles { get; } = new List<Role>();
}
