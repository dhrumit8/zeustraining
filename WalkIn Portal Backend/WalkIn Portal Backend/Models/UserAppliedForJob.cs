using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class UserAppliedForJob
{
    public int UserDetailsUserId { get; set; }

    public int JobId { get; set; }

    public string TimeSlotSelected { get; set; } = null!;

    public string? Resume { get; set; }

    public int VenueDetailsId { get; set; }

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual Job Job { get; set; } = null!;

    public virtual ICollection<UserAppliedForJobHasRolesPreference> UserAppliedForJobHasRolesPreferences { get; } = new List<UserAppliedForJobHasRolesPreference>();

    public virtual UserDetail UserDetailsUser { get; set; } = null!;

    public virtual VenueDetail VenueDetails { get; set; } = null!;
}
