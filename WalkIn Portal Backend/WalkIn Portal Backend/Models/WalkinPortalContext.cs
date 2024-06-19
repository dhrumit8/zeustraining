using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WalkIn_Portal_Backend.Models;

public partial class WalkinPortalContext : DbContext
{
    public WalkinPortalContext()
    {
    }

    public WalkinPortalContext(DbContextOptions<WalkinPortalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EducationalQualification> EducationalQualifications { get; set; }

    public virtual DbSet<ExperiencedHasTechnologiesExpertise> ExperiencedHasTechnologiesExpertises { get; set; }

    public virtual DbSet<ExperiencedHasTechnologiesFamiliar> ExperiencedHasTechnologiesFamiliars { get; set; }

    public virtual DbSet<ExperiencedQualification> ExperiencedQualifications { get; set; }

    public virtual DbSet<FresherHasTechnologiesFamiliar> FresherHasTechnologiesFamiliars { get; set; }

    public virtual DbSet<FresherQualification> FresherQualifications { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobHasTimeSlot> JobHasTimeSlots { get; set; }

    public virtual DbSet<JobPreRequisite> JobPreRequisites { get; set; }

    public virtual DbSet<JobRole> JobRoles { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<ProfessionalQualification> ProfessionalQualifications { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolesAvailable> RolesAvailables { get; set; }

    public virtual DbSet<RolesDetail> RolesDetails { get; set; }

    public virtual DbSet<TechnologiesExpertise> TechnologiesExpertises { get; set; }

    public virtual DbSet<TechnologiesFamiliar> TechnologiesFamiliars { get; set; }

    public virtual DbSet<TimeSlot> TimeSlots { get; set; }

    public virtual DbSet<UserAppliedForJob> UserAppliedForJobs { get; set; }

    public virtual DbSet<UserAppliedForJobHasRolesPreference> UserAppliedForJobHasRolesPreferences { get; set; }

    public virtual DbSet<UserDetail> UserDetails { get; set; }

    public virtual DbSet<UserHasJobRole> UserHasJobRoles { get; set; }

    public virtual DbSet<VenueDetail> VenueDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=walkin_portal;uid=root;pwd=123456", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.36-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb3_general_ci")
            .HasCharSet("utf8mb3");

        modelBuilder.Entity<EducationalQualification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("educational_qualifications");

            entity.HasIndex(e => e.UserDetailsUserId, "fk_educational_qualifications_user_details1_idx");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.College)
                .HasMaxLength(45)
                .HasColumnName("college");
            entity.Property(e => e.CollegeLocation)
                .HasMaxLength(45)
                .HasColumnName("college_location");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");
            entity.Property(e => e.Percentage)
                .HasPrecision(5, 2)
                .HasColumnName("percentage");
            entity.Property(e => e.Qualification)
                .HasMaxLength(45)
                .HasColumnName("qualification");
            entity.Property(e => e.StreamBranch)
                .HasMaxLength(45)
                .HasColumnName("stream_branch");
            entity.Property(e => e.UserDetailsUserId).HasColumnName("user_details_user_id");
            entity.Property(e => e.YearOfPassing)
                .HasColumnType("year")
                .HasColumnName("year_of_passing");

            //entity.HasOne(d => d.UserDetailsUser).WithMany(p => p.EducationalQualifications)
            //    .HasForeignKey(d => d.UserDetailsUserId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("fk_educational_qualifications_user_details1");
        });

        modelBuilder.Entity<ExperiencedHasTechnologiesExpertise>(entity =>
        {
            entity.HasKey(e => new { e.ExperiencedQualificationId, e.TechnologiesExpertiseId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("experienced_has_technologies_expertise");

            //entity.HasIndex(e => e.ExperiencedQualificationId, "fk_experienced_qualification_has_technologies_expertise_exp_idx");

            //entity.HasIndex(e => e.TechnologiesExpertiseId, "fk_experienced_qualification_has_technologies_expertise_tec_idx");

            entity.Property(e => e.ExperiencedQualificationId).HasColumnName("experienced_qualification_id");
            entity.Property(e => e.TechnologiesExpertiseId).HasColumnName("technologies_expertise_id");
            //entity.Property(e => e.DtCreated)
            //    .HasDefaultValueSql("CURRENT_TIMESTAMP")
            //    .HasColumnType("datetime")
            //    .HasColumnName("dt_created");
            //entity.Property(e => e.DtModified)
            //    .ValueGeneratedOnAddOrUpdate()
            //    .HasDefaultValueSql("CURRENT_TIMESTAMP")
            //    .HasColumnType("datetime")
            //    .HasColumnName("dt_modified");

            //entity.HasOne(d => d.ExperiencedQualification).WithMany(p => p.ExperiencedHasTechnologiesExpertises)
            //    .HasForeignKey(d => d.ExperiencedQualificationId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("fk_experienced_qualification_has_technologies_expertise_exper1");

            //entity.HasOne(d => d.TechnologiesExpertise).WithMany(p => p.ExperiencedHasTechnologiesExpertises)
            //    .HasForeignKey(d => d.TechnologiesExpertiseId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("fk_experienced_qualification_has_technologies_expertise_techn1");
        });

        modelBuilder.Entity<ExperiencedHasTechnologiesFamiliar>(entity =>
        {
            entity.HasKey(e => new { e.ExperiencedQualificationId, e.TechnologiesFamiliarId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("experienced_has_technologies_familiar");

            entity.HasIndex(e => e.ExperiencedQualificationId, "fk_experienced_qualification_has_technologies_familiar_expe_idx");

            entity.HasIndex(e => e.TechnologiesFamiliarId, "fk_experienced_qualification_has_technologies_familiar_tech_idx");

            entity.Property(e => e.ExperiencedQualificationId).HasColumnName("experienced_qualification_id");
            entity.Property(e => e.TechnologiesFamiliarId).HasColumnName("technologies_familiar_id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");

            entity.HasOne(d => d.ExperiencedQualification).WithMany(p => p.ExperiencedHasTechnologiesFamiliars)
                .HasForeignKey(d => d.ExperiencedQualificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_experienced_qualification_has_technologies_familiar_experi1");

            entity.HasOne(d => d.TechnologiesFamiliar).WithMany(p => p.ExperiencedHasTechnologiesFamiliars)
                .HasForeignKey(d => d.TechnologiesFamiliarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_experienced_qualification_has_technologies_familiar_techno1");
        });

        modelBuilder.Entity<ExperiencedQualification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("experienced_qualification");

            entity.HasIndex(e => e.ProfessionalQualificationId, "fk_experienced_qualification_professional_qualification1_idx");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApperedForZeusTest).HasColumnName("appered_for_zeus_test");
            entity.Property(e => e.CurrentCtc).HasColumnName("current_ctc");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");
            entity.Property(e => e.ExpectedCtc).HasColumnName("expected_ctc");
            entity.Property(e => e.NoticePeriodEnd).HasColumnName("notice_period_end");
            entity.Property(e => e.NoticePeriodLength).HasColumnName("notice_period_length");
            entity.Property(e => e.OnNoticePeriod).HasColumnName("on_notice_period");
            entity.Property(e => e.OtherTechnologiesExpertise)
                .HasMaxLength(45)
                .HasColumnName("other_technologies_expertise");
            entity.Property(e => e.OtherTechnologiesFamiliar)
                .HasMaxLength(45)
                .HasColumnName("other_technologies_familiar");
            entity.Property(e => e.ProfessionalQualificationId).HasColumnName("professional_qualification_id");
            entity.Property(e => e.RoleApplied)
                .HasMaxLength(45)
                .HasColumnName("role_applied");
            entity.Property(e => e.YearsOfExperience).HasColumnName("years_of_experience");

            //entity.HasOne(d => d.ProfessionalQualification).WithMany(p => p.ExperiencedQualifications)
            //    .HasForeignKey(d => d.ProfessionalQualificationId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("fk_experienced_qualification_professional_qualification1");
        });

        modelBuilder.Entity<FresherHasTechnologiesFamiliar>(entity =>
        {
            entity.HasKey(e => new { e.FresherQualificationId, e.TechnologiesFamiliarId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("fresher_has_technologies_familiar");

            entity.HasIndex(e => e.FresherQualificationId, "fk_fresher_qualification_has_technologies_familiar_fresher__idx");

            entity.HasIndex(e => e.TechnologiesFamiliarId, "fk_fresher_qualification_has_technologies_familiar_technolo_idx");

            entity.Property(e => e.FresherQualificationId).HasColumnName("fresher_qualification_id");
            entity.Property(e => e.TechnologiesFamiliarId).HasColumnName("technologies_familiar_id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");

            entity.HasOne(d => d.FresherQualification).WithMany(p => p.FresherHasTechnologiesFamiliars)
                .HasForeignKey(d => d.FresherQualificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fresher_qualification_has_technologies_familiar_fresher_qu1");

            entity.HasOne(d => d.TechnologiesFamiliar).WithMany(p => p.FresherHasTechnologiesFamiliars)
                .HasForeignKey(d => d.TechnologiesFamiliarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fresher_qualification_has_technologies_familiar_technologi1");
        });

        modelBuilder.Entity<FresherQualification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("fresher_qualification");

            entity.HasIndex(e => e.ProfessionalQualificationId, "fk_fresher_qualification_professional_qualification1_idx");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppearedForZeusTest).HasColumnName("appeared_for_zeus_test");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");
            entity.Property(e => e.OtherTechnologiesFamiliar)
                .HasMaxLength(45)
                .HasColumnName("other_technologies_familiar");
            entity.Property(e => e.ProfessionalQualificationId).HasColumnName("professional_qualification_id");
            entity.Property(e => e.RoleAppliedForZeusTest)
                .HasMaxLength(45)
                .HasColumnName("role_applied_for_zeus_test");

            //entity.HasOne(d => d.ProfessionalQualification).WithMany(p => p.FresherQualifications)
            //    .HasForeignKey(d => d.ProfessionalQualificationId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("fk_fresher_qualification_professional_qualification1");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("job");

            entity.HasIndex(e => e.JobPreRequisitesId, "fk_job_job_details1_idx");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Expires).HasColumnName("expires");
            entity.Property(e => e.JobPreRequisitesId).HasColumnName("job_pre_requisites_id");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(255)
                .HasColumnName("job_title");
            entity.Property(e => e.Location)
                .HasMaxLength(45)
                .HasColumnName("location");
            entity.Property(e => e.SpecialOpportunity)
                .HasMaxLength(255)
                .HasColumnName("special_opportunity");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.JobPreRequisites).WithMany(p => p.Jobs)
                .HasForeignKey(d => d.JobPreRequisitesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_job_job_details1");
        });

        modelBuilder.Entity<JobHasTimeSlot>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.TimeSlotsId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("job_has_time_slots");

            entity.HasIndex(e => e.JobId, "fk_job_details_has_time_slots_job_details1_idx");

            entity.HasIndex(e => e.TimeSlotsId, "fk_job_has_time_slots_job1_idx");

            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.TimeSlotsId).HasColumnName("time_slots_id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");

            entity.HasOne(d => d.Job).WithMany(p => p.JobHasTimeSlots)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_job_has_time_slots_job");

            entity.HasOne(d => d.TimeSlots).WithMany(p => p.JobHasTimeSlots)
                .HasForeignKey(d => d.TimeSlotsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_job_has_time_slots_job1");
        });

        modelBuilder.Entity<JobPreRequisite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("job_pre_requisites");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");
            entity.Property(e => e.GeneralInstructions)
                .HasColumnType("text")
                .HasColumnName("general_instructions");
            entity.Property(e => e.InstructionsForExam)
                .HasColumnType("text")
                .HasColumnName("Instructions_for_exam");
            entity.Property(e => e.MinSystemRequirements)
                .HasColumnType("text")
                .HasColumnName("min_system_requirements");
            entity.Property(e => e.Process)
                .HasColumnType("text")
                .HasColumnName("process");
        });

        modelBuilder.Entity<JobRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("job_roles");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");
            entity.Property(e => e.Roles)
                .HasMaxLength(45)
                .HasColumnName("roles");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("login");

            entity.HasIndex(e => e.Email, "email_UNIQUE").IsUnique();

            entity.HasIndex(e => e.UserDetailsUserId, "fk_login_user_details1_idx");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            //entity.Property(e => e.DtCreated)
            //    .HasDefaultValueSql("CURRENT_TIMESTAMP")
            //    .HasColumnType("datetime")
            //    .HasColumnName("dt_created");
            //entity.Property(e => e.DtModified)
            //   .ValueGeneratedOnAddOrUpdate()
            //    .HasDefaultValueSql("CURRENT_TIMESTAMP")
            //    .HasColumnType("datetime")
            //    .HasColumnName("dt_modified");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.UserDetailsUserId).HasColumnName("user_details_user_id");

            //entity.HasOne(d => d.UserDetailsUser).WithMany(p => p.Logins)
            //    .HasForeignKey(d => d.UserDetailsUserId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("fk_login_user_details1");
        });

        modelBuilder.Entity<ProfessionalQualification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("professional_qualification");

            entity.HasIndex(e => e.UserDetailsUserId, "fk_professional_qualification_user_details1_idx");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");
            entity.Property(e => e.Experienced).HasColumnName("experienced");
            entity.Property(e => e.Fresher).HasColumnName("fresher");
            entity.Property(e => e.UserDetailsUserId).HasColumnName("user_details_user_id");

            //entity.HasOne(d => d.UserDetailsUser).WithMany(p => p.ProfessionalQualifications)
            //    .HasForeignKey(d => d.UserDetailsUserId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("fk_professional_qualification_user_details1");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("roles");

            entity.HasIndex(e => e.RolesDetailId, "fk_roles_roles_detail1_idx");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");
            entity.Property(e => e.Roles)
                .HasMaxLength(45)
                .HasColumnName("roles");
            entity.Property(e => e.RolesDetailId).HasColumnName("roles_detail_id");

            entity.HasOne(d => d.RolesDetail).WithMany(p => p.Roles)
                .HasForeignKey(d => d.RolesDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_roles_roles_detail1");
        });

        modelBuilder.Entity<RolesAvailable>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.JobRolesId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("roles_available");

            entity.HasIndex(e => e.JobId, "fk_job_has_job_roles_job1_idx");

            entity.HasIndex(e => e.JobRolesId, "fk_job_has_job_roles_job_roles1_idx");

            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.JobRolesId).HasColumnName("job_roles_id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");

            entity.HasOne(d => d.Job).WithMany(p => p.RolesAvailables)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_job_has_job_roles_job1");

            entity.HasOne(d => d.JobRoles).WithMany(p => p.RolesAvailables)
                .HasForeignKey(d => d.JobRolesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_job_has_job_roles_job_roles1");
        });

        modelBuilder.Entity<RolesDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("roles_detail");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");
            entity.Property(e => e.GrossPackage).HasColumnName("gross_package");
            entity.Property(e => e.Requirements)
                .HasColumnType("text")
                .HasColumnName("requirements");
            entity.Property(e => e.RoleDescription)
                .HasColumnType("text")
                .HasColumnName("role_description");
        });

        modelBuilder.Entity<TechnologiesExpertise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("technologies_expertise");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");
            entity.Property(e => e.Technologies)
                .HasMaxLength(45)
                .HasColumnName("technologies");
        });

        modelBuilder.Entity<TechnologiesFamiliar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("technologies_familiar");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");
            entity.Property(e => e.Technologies)
                .HasMaxLength(45)
                .HasColumnName("technologies");
        });

        modelBuilder.Entity<TimeSlot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("time_slots");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");
            entity.Property(e => e.Slots)
                .HasMaxLength(45)
                .HasColumnName("slots");
        });

        modelBuilder.Entity<UserAppliedForJob>(entity =>
        {
            entity.HasKey(e => new { e.UserDetailsUserId, e.JobId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("user_applied_for_job");

            entity.HasIndex(e => e.VenueDetailsId, "fk_user_applied_for_job_venue_details1_idx");

            entity.HasIndex(e => e.JobId, "fk_user_details_has_job_job1_idx");

            entity.HasIndex(e => e.UserDetailsUserId, "fk_user_details_has_job_user_details1_idx");

            entity.Property(e => e.UserDetailsUserId).HasColumnName("user_details_user_id");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");
            entity.Property(e => e.Resume)
                .HasMaxLength(255)
                .HasColumnName("resume");
            entity.Property(e => e.TimeSlotSelected)
                .HasMaxLength(45)
                .HasColumnName("time_slot_selected");
            entity.Property(e => e.VenueDetailsId).HasColumnName("venue_details_id");

            entity.HasOne(d => d.Job).WithMany(p => p.UserAppliedForJobs)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_details_has_job_job1");

            //entity.HasOne(d => d.UserDetailsUser).WithMany(p => p.UserAppliedForJobs)
            //    .HasForeignKey(d => d.UserDetailsUserId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("fk_user_details_has_job_user_details1");

            entity.HasOne(d => d.VenueDetails).WithMany(p => p.UserAppliedForJobs)
                .HasForeignKey(d => d.VenueDetailsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_applied_for_job_venue_details1");
        });

        modelBuilder.Entity<UserAppliedForJobHasRolesPreference>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.JobId, e.RolesId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("user_applied_for_job_has_roles_preferences");

            entity.HasIndex(e => e.RolesId, "fk_user_applied_for_job_has_roles_roles1_idx");

            entity.HasIndex(e => new { e.UserId, e.JobId }, "fk_user_applied_for_job_has_roles_user_applied_for_job1_idx");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.RolesId).HasColumnName("roles_id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");

            entity.HasOne(d => d.Roles).WithMany(p => p.UserAppliedForJobHasRolesPreferences)
                .HasForeignKey(d => d.RolesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_applied_for_job_has_roles_roles1");

            entity.HasOne(d => d.UserAppliedForJob).WithMany(p => p.UserAppliedForJobHasRolesPreferences)
                .HasForeignKey(d => new { d.UserId, d.JobId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_applied_for_job_has_roles_user_applied_for_job1");
        });

        modelBuilder.Entity<UserDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("user_details");

            entity.HasIndex(e => e.Email, "email_UNIQUE").IsUnique();

            entity.HasIndex(e => e.UserId, "user_id_UNIQUE").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(45)
                .HasColumnName("country_code");
            //entity.Property(e => e.DtCreated)
            //    .HasDefaultValueSql("CURRENT_TIMESTAMP")
            //    .HasColumnType("datetime")
            //    .HasColumnName("dt_created");
            //entity.Property(e => e.DtModified)
            //    .ValueGeneratedOnAddOrUpdate()
            //    .HasDefaultValueSql("CURRENT_TIMESTAMP")
            //    .HasColumnType("datetime")
            //    .HasColumnName("dt_modified");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(45)
                .HasColumnName("first_name");
            entity.Property(e => e.JobRelatedEmail)
                .HasDefaultValueSql("'0'")
                .HasColumnName("job_related_email");
            entity.Property(e => e.LastName)
                .HasMaxLength(45)
                .HasColumnName("last_name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(45)
                .HasColumnName("phone_number");
            entity.Property(e => e.PortfolioUrl)
                .HasMaxLength(255)
                .HasColumnName("portfolio_url");
            entity.Property(e => e.ProfileImage)
                .HasMaxLength(255)
                .HasColumnName("profile_image");
            entity.Property(e => e.Referal)
                .HasMaxLength(45)
                .HasColumnName("referal");
            entity.Property(e => e.Resume)
                .HasMaxLength(255)
                .HasColumnName("resume");
        });

        modelBuilder.Entity<UserHasJobRole>(entity =>
        {
            entity.HasKey(e => new { e.UserDetailsUserId, e.JobRolesId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("user_has_job_roles");

            entity.HasIndex(e => e.JobRolesId, "fk_user_details_has_job_roles_job_roles1_idx");

            entity.HasIndex(e => e.UserDetailsUserId, "fk_user_details_has_job_roles_user_details1_idx");

            entity.Property(e => e.UserDetailsUserId).HasColumnName("user_details_user_id");
            entity.Property(e => e.JobRolesId).HasColumnName("job_roles_id");
            entity.Property(e => e.DtCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_created");
            entity.Property(e => e.DtModified)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("dt_modified");

            entity.HasOne(d => d.JobRoles).WithMany(p => p.UserHasJobRoles)
                .HasForeignKey(d => d.JobRolesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_details_has_job_roles_job_roles1");

            //entity.HasOne(d => d.UserDetailsUser).WithMany(p => p.UserHasJobRoles)
            //    .HasForeignKey(d => d.UserDetailsUserId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("fk_user_details_has_job_roles_user_details1");
        });

        modelBuilder.Entity<VenueDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("venue_details");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ThingsToRemember)
                .HasColumnType("text")
                .HasColumnName("things_to_remember");
            entity.Property(e => e.Venue)
                .HasColumnType("text")
                .HasColumnName("venue");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
