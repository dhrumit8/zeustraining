using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class VenueDetail
{
    public int Id { get; set; }

    public string Venue { get; set; } = null!;

    public string? ThingsToRemember { get; set; }

    public virtual ICollection<UserAppliedForJob> UserAppliedForJobs { get; } = new List<UserAppliedForJob>();
}
