using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WalkInPortalBackend.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb3");

            migrationBuilder.CreateTable(
                name: "job_pre_requisites",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    generalinstructions = table.Column<string>(name: "general_instructions", type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Instructionsforexam = table.Column<string>(name: "Instructions_for_exam", type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    minsystemrequirements = table.Column<string>(name: "min_system_requirements", type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    process = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "job_roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    roles = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "roles_detail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    grosspackage = table.Column<int>(name: "gross_package", type: "int", nullable: false),
                    roledescription = table.Column<string>(name: "role_description", type: "text", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    requirements = table.Column<string>(type: "text", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "technologies_expertise",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    technologies = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "technologies_familiar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    technologies = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "time_slots",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    slots = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "user_details",
                columns: table => new
                {
                    userid = table.Column<int>(name: "user_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    firstname = table.Column<string>(name: "first_name", type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    lastname = table.Column<string>(name: "last_name", type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    email = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    countrycode = table.Column<string>(name: "country_code", type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    phonenumber = table.Column<string>(name: "phone_number", type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    resume = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    profileimage = table.Column<string>(name: "profile_image", type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    portfoliourl = table.Column<string>(name: "portfolio_url", type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    referal = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    jobrelatedemail = table.Column<sbyte>(name: "job_related_email", type: "tinyint", nullable: true, defaultValueSql: "'0'"),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.userid);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "venue_details",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    venue = table.Column<string>(type: "text", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    thingstoremember = table.Column<string>(name: "things_to_remember", type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "job",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    jobtitle = table.Column<string>(name: "job_title", type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    startdate = table.Column<DateOnly>(name: "start_date", type: "date", nullable: false),
                    enddate = table.Column<DateOnly>(name: "end_date", type: "date", nullable: false),
                    location = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    specialopportunity = table.Column<string>(name: "special_opportunity", type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    expires = table.Column<int>(type: "int", nullable: true),
                    jobprerequisitesid = table.Column<int>(name: "job_pre_requisites_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "fk_job_job_details1",
                        column: x => x.jobprerequisitesid,
                        principalTable: "job_pre_requisites",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    roles = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    rolesdetailid = table.Column<int>(name: "roles_detail_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "fk_roles_roles_detail1",
                        column: x => x.rolesdetailid,
                        principalTable: "roles_detail",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "educational_qualifications",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    percentage = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    yearofpassing = table.Column<short>(name: "year_of_passing", type: "year", nullable: false),
                    qualification = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    streambranch = table.Column<string>(name: "stream_branch", type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    college = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    collegelocation = table.Column<string>(name: "college_location", type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    userdetailsuserid = table.Column<int>(name: "user_details_user_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "fk_educational_qualifications_user_details1",
                        column: x => x.userdetailsuserid,
                        principalTable: "user_details",
                        principalColumn: "user_id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    password = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    userdetailsuserid = table.Column<int>(name: "user_details_user_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "fk_login_user_details1",
                        column: x => x.userdetailsuserid,
                        principalTable: "user_details",
                        principalColumn: "user_id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "professional_qualification",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fresher = table.Column<sbyte>(type: "tinyint", nullable: true),
                    experienced = table.Column<sbyte>(type: "tinyint", nullable: true),
                    userdetailsuserid = table.Column<int>(name: "user_details_user_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "fk_professional_qualification_user_details1",
                        column: x => x.userdetailsuserid,
                        principalTable: "user_details",
                        principalColumn: "user_id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "user_has_job_roles",
                columns: table => new
                {
                    userdetailsuserid = table.Column<int>(name: "user_details_user_id", type: "int", nullable: false),
                    jobrolesid = table.Column<int>(name: "job_roles_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.userdetailsuserid, x.jobrolesid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_user_details_has_job_roles_job_roles1",
                        column: x => x.jobrolesid,
                        principalTable: "job_roles",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_user_details_has_job_roles_user_details1",
                        column: x => x.userdetailsuserid,
                        principalTable: "user_details",
                        principalColumn: "user_id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "job_has_time_slots",
                columns: table => new
                {
                    jobid = table.Column<int>(name: "job_id", type: "int", nullable: false),
                    timeslotsid = table.Column<int>(name: "time_slots_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.jobid, x.timeslotsid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_job_has_time_slots_job",
                        column: x => x.jobid,
                        principalTable: "job",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_job_has_time_slots_job1",
                        column: x => x.timeslotsid,
                        principalTable: "time_slots",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "user_applied_for_job",
                columns: table => new
                {
                    userdetailsuserid = table.Column<int>(name: "user_details_user_id", type: "int", nullable: false),
                    jobid = table.Column<int>(name: "job_id", type: "int", nullable: false),
                    timeslotselected = table.Column<string>(name: "time_slot_selected", type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    resume = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    venuedetailsid = table.Column<int>(name: "venue_details_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.userdetailsuserid, x.jobid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_user_applied_for_job_venue_details1",
                        column: x => x.venuedetailsid,
                        principalTable: "venue_details",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_user_details_has_job_job1",
                        column: x => x.jobid,
                        principalTable: "job",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_user_details_has_job_user_details1",
                        column: x => x.userdetailsuserid,
                        principalTable: "user_details",
                        principalColumn: "user_id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "roles_available",
                columns: table => new
                {
                    jobid = table.Column<int>(name: "job_id", type: "int", nullable: false),
                    jobrolesid = table.Column<int>(name: "job_roles_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.jobid, x.jobrolesid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_job_has_job_roles_job1",
                        column: x => x.jobid,
                        principalTable: "job",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_job_has_job_roles_job_roles1",
                        column: x => x.jobrolesid,
                        principalTable: "roles",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "experienced_qualification",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    yearsofexperience = table.Column<int>(name: "years_of_experience", type: "int", nullable: false),
                    currentctc = table.Column<int>(name: "current_ctc", type: "int", nullable: false),
                    expectedctc = table.Column<int>(name: "expected_ctc", type: "int", nullable: false),
                    onnoticeperiod = table.Column<sbyte>(name: "on_notice_period", type: "tinyint", nullable: false),
                    noticeperiodend = table.Column<DateOnly>(name: "notice_period_end", type: "date", nullable: true),
                    noticeperiodlength = table.Column<int>(name: "notice_period_length", type: "int", nullable: true),
                    apperedforzeustest = table.Column<sbyte>(name: "appered_for_zeus_test", type: "tinyint", nullable: false),
                    roleapplied = table.Column<string>(name: "role_applied", type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    othertechnologiesfamiliar = table.Column<string>(name: "other_technologies_familiar", type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    othertechnologiesexpertise = table.Column<string>(name: "other_technologies_expertise", type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    professionalqualificationid = table.Column<int>(name: "professional_qualification_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "fk_experienced_qualification_professional_qualification1",
                        column: x => x.professionalqualificationid,
                        principalTable: "professional_qualification",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "fresher_qualification",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    appearedforzeustest = table.Column<sbyte>(name: "appeared_for_zeus_test", type: "tinyint", nullable: false),
                    roleappliedforzeustest = table.Column<string>(name: "role_applied_for_zeus_test", type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    othertechnologiesfamiliar = table.Column<string>(name: "other_technologies_familiar", type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    professionalqualificationid = table.Column<int>(name: "professional_qualification_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "fk_fresher_qualification_professional_qualification1",
                        column: x => x.professionalqualificationid,
                        principalTable: "professional_qualification",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "user_applied_for_job_has_roles_preferences",
                columns: table => new
                {
                    userid = table.Column<int>(name: "user_id", type: "int", nullable: false),
                    jobid = table.Column<int>(name: "job_id", type: "int", nullable: false),
                    rolesid = table.Column<int>(name: "roles_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.userid, x.jobid, x.rolesid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                    table.ForeignKey(
                        name: "fk_user_applied_for_job_has_roles_roles1",
                        column: x => x.rolesid,
                        principalTable: "roles",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_user_applied_for_job_has_roles_user_applied_for_job1",
                        columns: x => new { x.userid, x.jobid },
                        principalTable: "user_applied_for_job",
                        principalColumns: new[] { "user_details_user_id", "job_id" });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "experienced_has_technologies_expertise",
                columns: table => new
                {
                    experiencedqualificationid = table.Column<int>(name: "experienced_qualification_id", type: "int", nullable: false),
                    technologiesexpertiseid = table.Column<int>(name: "technologies_expertise_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.experiencedqualificationid, x.technologiesexpertiseid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_experienced_qualification_has_technologies_expertise_exper1",
                        column: x => x.experiencedqualificationid,
                        principalTable: "experienced_qualification",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_experienced_qualification_has_technologies_expertise_techn1",
                        column: x => x.technologiesexpertiseid,
                        principalTable: "technologies_expertise",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "experienced_has_technologies_familiar",
                columns: table => new
                {
                    experiencedqualificationid = table.Column<int>(name: "experienced_qualification_id", type: "int", nullable: false),
                    technologiesfamiliarid = table.Column<int>(name: "technologies_familiar_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.experiencedqualificationid, x.technologiesfamiliarid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_experienced_qualification_has_technologies_familiar_experi1",
                        column: x => x.experiencedqualificationid,
                        principalTable: "experienced_qualification",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_experienced_qualification_has_technologies_familiar_techno1",
                        column: x => x.technologiesfamiliarid,
                        principalTable: "technologies_familiar",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "fresher_has_technologies_familiar",
                columns: table => new
                {
                    fresherqualificationid = table.Column<int>(name: "fresher_qualification_id", type: "int", nullable: false),
                    technologiesfamiliarid = table.Column<int>(name: "technologies_familiar_id", type: "int", nullable: false),
                    dtcreated = table.Column<DateTime>(name: "dt_created", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dtmodified = table.Column<DateTime>(name: "dt_modified", type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.fresherqualificationid, x.technologiesfamiliarid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_fresher_qualification_has_technologies_familiar_fresher_qu1",
                        column: x => x.fresherqualificationid,
                        principalTable: "fresher_qualification",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_fresher_qualification_has_technologies_familiar_technologi1",
                        column: x => x.technologiesfamiliarid,
                        principalTable: "technologies_familiar",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateIndex(
                name: "fk_educational_qualifications_user_details1_idx",
                table: "educational_qualifications",
                column: "user_details_user_id");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE",
                table: "educational_qualifications",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_experienced_qualification_has_technologies_expertise_exp_idx",
                table: "experienced_has_technologies_expertise",
                column: "experienced_qualification_id");

            migrationBuilder.CreateIndex(
                name: "fk_experienced_qualification_has_technologies_expertise_tec_idx",
                table: "experienced_has_technologies_expertise",
                column: "technologies_expertise_id");

            migrationBuilder.CreateIndex(
                name: "fk_experienced_qualification_has_technologies_familiar_expe_idx",
                table: "experienced_has_technologies_familiar",
                column: "experienced_qualification_id");

            migrationBuilder.CreateIndex(
                name: "fk_experienced_qualification_has_technologies_familiar_tech_idx",
                table: "experienced_has_technologies_familiar",
                column: "technologies_familiar_id");

            migrationBuilder.CreateIndex(
                name: "fk_experienced_qualification_professional_qualification1_idx",
                table: "experienced_qualification",
                column: "professional_qualification_id");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE1",
                table: "experienced_qualification",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_fresher_qualification_has_technologies_familiar_fresher__idx",
                table: "fresher_has_technologies_familiar",
                column: "fresher_qualification_id");

            migrationBuilder.CreateIndex(
                name: "fk_fresher_qualification_has_technologies_familiar_technolo_idx",
                table: "fresher_has_technologies_familiar",
                column: "technologies_familiar_id");

            migrationBuilder.CreateIndex(
                name: "fk_fresher_qualification_professional_qualification1_idx",
                table: "fresher_qualification",
                column: "professional_qualification_id");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE2",
                table: "fresher_qualification",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_job_job_details1_idx",
                table: "job",
                column: "job_pre_requisites_id");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE3",
                table: "job",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_job_details_has_time_slots_job_details1_idx",
                table: "job_has_time_slots",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "fk_job_has_time_slots_job1_idx",
                table: "job_has_time_slots",
                column: "time_slots_id");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE4",
                table: "job_pre_requisites",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE5",
                table: "job_roles",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "email_UNIQUE",
                table: "login",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_login_user_details1_idx",
                table: "login",
                column: "user_details_user_id");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE6",
                table: "login",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_professional_qualification_user_details1_idx",
                table: "professional_qualification",
                column: "user_details_user_id");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE7",
                table: "professional_qualification",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_roles_roles_detail1_idx",
                table: "roles",
                column: "roles_detail_id");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE8",
                table: "roles",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_job_has_job_roles_job_roles1_idx",
                table: "roles_available",
                column: "job_roles_id");

            migrationBuilder.CreateIndex(
                name: "fk_job_has_job_roles_job1_idx",
                table: "roles_available",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE9",
                table: "roles_detail",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE10",
                table: "technologies_expertise",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE11",
                table: "technologies_familiar",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE12",
                table: "time_slots",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_user_applied_for_job_venue_details1_idx",
                table: "user_applied_for_job",
                column: "venue_details_id");

            migrationBuilder.CreateIndex(
                name: "fk_user_details_has_job_job1_idx",
                table: "user_applied_for_job",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "fk_user_details_has_job_user_details1_idx",
                table: "user_applied_for_job",
                column: "user_details_user_id");

            migrationBuilder.CreateIndex(
                name: "fk_user_applied_for_job_has_roles_roles1_idx",
                table: "user_applied_for_job_has_roles_preferences",
                column: "roles_id");

            migrationBuilder.CreateIndex(
                name: "fk_user_applied_for_job_has_roles_user_applied_for_job1_idx",
                table: "user_applied_for_job_has_roles_preferences",
                columns: new[] { "user_id", "job_id" });

            migrationBuilder.CreateIndex(
                name: "email_UNIQUE1",
                table: "user_details",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "phone_number_UNIQUE",
                table: "user_details",
                column: "phone_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "user_id_UNIQUE",
                table: "user_details",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_user_details_has_job_roles_job_roles1_idx",
                table: "user_has_job_roles",
                column: "job_roles_id");

            migrationBuilder.CreateIndex(
                name: "fk_user_details_has_job_roles_user_details1_idx",
                table: "user_has_job_roles",
                column: "user_details_user_id");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE13",
                table: "venue_details",
                column: "id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "educational_qualifications");

            migrationBuilder.DropTable(
                name: "experienced_has_technologies_expertise");

            migrationBuilder.DropTable(
                name: "experienced_has_technologies_familiar");

            migrationBuilder.DropTable(
                name: "fresher_has_technologies_familiar");

            migrationBuilder.DropTable(
                name: "job_has_time_slots");

            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "roles_available");

            migrationBuilder.DropTable(
                name: "user_applied_for_job_has_roles_preferences");

            migrationBuilder.DropTable(
                name: "user_has_job_roles");

            migrationBuilder.DropTable(
                name: "technologies_expertise");

            migrationBuilder.DropTable(
                name: "experienced_qualification");

            migrationBuilder.DropTable(
                name: "fresher_qualification");

            migrationBuilder.DropTable(
                name: "technologies_familiar");

            migrationBuilder.DropTable(
                name: "time_slots");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "user_applied_for_job");

            migrationBuilder.DropTable(
                name: "job_roles");

            migrationBuilder.DropTable(
                name: "professional_qualification");

            migrationBuilder.DropTable(
                name: "roles_detail");

            migrationBuilder.DropTable(
                name: "venue_details");

            migrationBuilder.DropTable(
                name: "job");

            migrationBuilder.DropTable(
                name: "user_details");

            migrationBuilder.DropTable(
                name: "job_pre_requisites");
        }
    }
}
