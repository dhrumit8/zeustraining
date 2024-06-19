using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Org.BouncyCastle.Math.EC.ECCurve;
using WalkIn_Portal_Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Mysqlx.Crud;
using System.Text.Json.Serialization;
using System.Text.Json;
using NuGet.Protocol;
using System.Data;
using NuGet.Packaging;

namespace WalkIn_Portal_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class UserController : Controller
    {
        private readonly WalkinPortalContext? _context;
        public UserController(WalkinPortalContext context, IConfiguration config)
        {
            _context = context;
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser(
            CreateUserRequest request

            //EducationalQualification educationalQualification, 
            //ProfessionalQualification professionalQualification, 
            //FresherQualification fresherQualification, 
            //ExperiencedQualification experiencedQualification
            )
        {
            UserDetail user = request.User;
            bool industrialDesigner = request.IndustrialDesigner;
            bool softwareEngineer = request.SoftwareEngineer;
            bool softwareQualityEngineer = request.SoftwareQualityEngineer;
            string password = request.Password;
            EducationalQualification educationalQualification = request.educationalQualification;
            string professionalQualification = request.professionalQualification;
            FresherQualification fresherQualification = request.fresherQualification;
            bool appearedInZeusTest = request.fresherQualification.AppearedForZeusTest;
            bool javascriptFresher = request.JavascriptFresher;
            bool angularJSFresher = request.AngularJSFresher;
            bool reactFresher = request.ReactFresher;
            bool nodeJSFresher = request.NodeJSFresher;
            ExperiencedQualification experiencedQualification = request.experiencedQualification;
            //Console.WriteLine("LOLLLLOOLL:", experiencedQualification.NoticePeriodEnd);
            //var NoticeEnd = experiencedQualification.NoticePeriodEnd != null ? $"'{experiencedQualification.NoticePeriodEnd:yyyy-MM-dd}'" : "NULL";

            //var NoticeLength = experiencedQualification.NoticePeriodLength != null ? $"'{experiencedQualification.NoticePeriodLength}'" : "NULL";
            //Console.WriteLine(user);
            if (_context.UserDetails.Where(u => u.Email == user.Email).FirstOrDefault() != null)
            {
                return Ok("Already Exists");
            }
            _context.UserDetails.Add(user);
            await _context.SaveChangesAsync();
            int userId = user.UserId;
            if (industrialDesigner)
            {
                var query = $"INSERT INTO user_has_job_roles (`user_details_user_id`, `job_roles_id`) VALUES({userId}, 1)";
                await _context.Database.ExecuteSqlRawAsync(query);
            }
            if (softwareEngineer)
            {
                var query = $"INSERT INTO user_has_job_roles (`user_details_user_id`, `job_roles_id`) VALUES({userId}, 2)";
                await _context.Database.ExecuteSqlRawAsync(query);
            }
            if (softwareQualityEngineer)
            {
                var query = $"INSERT INTO user_has_job_roles (`user_details_user_id`, `job_roles_id`) VALUES({userId}, 3)";
                await _context.Database.ExecuteSqlRawAsync(query);
            }
            var query1 = $"INSERT INTO login (`email`, `password`, `user_details_user_id`) VALUES('{user.Email}', '{password}', {userId})";

            await _context.Database.ExecuteSqlRawAsync(query1);

            //_context.EducationalQualifications.Add(educationalQualification);
            var query2 = $"INSERT INTO educational_qualifications (`percentage`, `year_of_passing`, `qualification`, `stream_branch`, `college`, `college_location`, `user_details_user_id`) VALUES ('{educationalQualification.Percentage}', '{educationalQualification.YearOfPassing}', '{educationalQualification.Qualification}', '{educationalQualification.StreamBranch}', '{educationalQualification.College}', '{educationalQualification.CollegeLocation}', {userId});";
            await _context.Database.ExecuteSqlRawAsync(query2);

            var professionalQualificationId = 0;
            if (professionalQualification == "Fresher")
            {
                var query = $"INSERT INTO professional_qualification (`id`, `user_details_user_id`, `Fresher`, `Experienced`) VALUES({userId}, {userId}, 1, 0)";
                await _context.Database.ExecuteSqlRawAsync(query);
                var query3 = $"INSERT INTO fresher_qualification (`id`, `appeared_for_zeus_test`, `role_applied_for_zeus_test`, `other_technologies_familiar`, `professional_qualification_id`) VALUES ({userId}, {appearedInZeusTest}, '{fresherQualification.RoleAppliedForZeusTest}', '{fresherQualification.OtherTechnologiesFamiliar}', {userId})";
                await _context.Database.ExecuteSqlRawAsync(query3);

                if (javascriptFresher)
                {
                    var insertJSFresher = $"INSERT INTO fresher_has_technologies_familiar (`fresher_qualification_id`, `technologies_familiar_id`) VALUES ({userId}, 1)";
                    await _context.Database.ExecuteSqlRawAsync(insertJSFresher);
                }
                if (angularJSFresher)
                {
                    var insertAngularFresher = $"INSERT INTO fresher_has_technologies_familiar (`fresher_qualification_id`, `technologies_familiar_id`) VALUES ({userId}, 2)";
                    await _context.Database.ExecuteSqlRawAsync(insertAngularFresher);
                }
                if (reactFresher)
                {
                    var insertReactFresher = $"INSERT INTO fresher_has_technologies_familiar (`fresher_qualification_id`, `technologies_familiar_id`) VALUES ({userId}, 3)";
                    await _context.Database.ExecuteSqlRawAsync(insertReactFresher);
                }
                if (nodeJSFresher)
                {
                    var insertNodeFresher = $"INSERT INTO fresher_has_technologies_familiar (`fresher_qualification_id`, `technologies_familiar_id`) VALUES ({userId}, 4)";
                    await _context.Database.ExecuteSqlRawAsync(insertNodeFresher);
                }
            }
            else if (professionalQualification == "Experienced")
            {
                var query = $"INSERT INTO professional_qualification (`id`, `user_details_user_id`, `Fresher`, `Experienced`) VALUES({userId}, {userId}, 0, 1)";
                await _context.Database.ExecuteSqlRawAsync(query);
                var insertExpQua = $"INSERT INTO experienced_qualification (`id`, `years_of_experience`, `current_ctc`, `expected_ctc`, `on_notice_period`, `notice_period_end`, `notice_period_length`, `appered_for_zeus_test`, `role_applied`, `other_technologies_familiar`, `other_technologies_expertise`, `professional_qualification_id`) VALUES ({userId}, '{experiencedQualification.YearsOfExperience}', '{experiencedQualification.CurrentCtc}', '{experiencedQualification.ExpectedCtc}', {experiencedQualification.OnNoticePeriod}, '{experiencedQualification.NoticePeriodEnd:yyyy-MM-dd}', '{experiencedQualification.NoticePeriodLength}', {experiencedQualification.ApperedForZeusTest}, '{experiencedQualification.RoleApplied}', '{experiencedQualification.OtherTechnologiesFamiliar}', '{experiencedQualification.OtherTechnologiesExpertise}', {userId})";
                await _context.Database.ExecuteSqlRawAsync(insertExpQua);

                if (request.JavascriptExpFam)
                {
                    var insertJSExpFam = $"INSERT INTO experienced_has_technologies_familiar (`experienced_qualification_id`, `technologies_familiar_id`) VALUES ({userId}, 1)";
                    await _context.Database.ExecuteSqlRawAsync(insertJSExpFam);
                }
                if (request.AngularJSExpFam)
                {
                    var insertAngularJSExpFam = $"INSERT INTO experienced_has_technologies_familiar (`experienced_qualification_id`, `technologies_familiar_id`) VALUES ({userId}, 2)";
                    await _context.Database.ExecuteSqlRawAsync(insertAngularJSExpFam);
                }
                if (request.ReactExpFam)
                {
                    var insertReactExpFam = $"INSERT INTO experienced_has_technologies_familiar (`experienced_qualification_id`, `technologies_familiar_id`) VALUES ({userId}, 3)";
                    await _context.Database.ExecuteSqlRawAsync(insertReactExpFam);
                }
                if (request.NodeJSExpFam)
                {
                    var insertNodeJSExpFam = $"INSERT INTO experienced_has_technologies_familiar (`experienced_qualification_id`, `technologies_familiar_id`) VALUES ({userId}, 4)";
                    await _context.Database.ExecuteSqlRawAsync(insertNodeJSExpFam);
                }
                if (request.JavascriptExpExpert)
                {
                    var insertJSExpExpert = $"INSERT INTO experienced_has_technologies_expertise (`experienced_qualification_id`, `technologies_expertise_id`) VALUES ({userId}, 1)";
                    await _context.Database.ExecuteSqlRawAsync(insertJSExpExpert);
                }
                if (request.AngularJSExpExpert)
                {
                    var insertAngularJSExpExpert = $"INSERT INTO experienced_has_technologies_expertise (`experienced_qualification_id`, `technologies_expertise_id`) VALUES ({userId}, 2)";
                    await _context.Database.ExecuteSqlRawAsync(insertAngularJSExpExpert);
                }
                if (request.ReactExpExpert)
                {
                    var insertReactExpExpert = $"INSERT INTO experienced_has_technologies_expertise (`experienced_qualification_id`, `technologies_expertise_id`) VALUES ({userId}, 3)";
                    await _context.Database.ExecuteSqlRawAsync(insertReactExpExpert);
                }
                if (request.NodeJSExpExpert)
                {
                    var insertNodeJSExpExpert = $"INSERT INTO experienced_has_technologies_expertise (`experienced_qualification_id`, `technologies_expertise_id`) VALUES ({userId}, 4)";
                    await _context.Database.ExecuteSqlRawAsync(insertNodeJSExpExpert);
                }
            }
            return Ok(user);
            //return Ok("Hello");
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(
            Models.Login user
            )
        {
            // _context.Logins.Add(user);
            // await _context.SaveChangesAsync();
            //return Ok(user);
            //return Ok("Hello");

            //var query = $"INSERT INTO login (Email, Password, UserDetailsUserId) " +
            //    $"VALUES ( '{user.Email}', '{user.Password}', {user.UserDetailsUserId};";

            var query = $"INSERT INTO login (`email`, `password`, `user_details_user_id`) VALUES('{user.Email}', '{user.Password}', {user.UserDetailsUserId})";

            await _context.Database.ExecuteSqlRawAsync(query);

            return Ok(user);
        }

        [HttpPost("select")]
        public async Task<IActionResult> Select()
        {
            var query = $"SELECT * FROM professtional_qualification";
            var result = await _context.ProfessionalQualifications.ToListAsync();
            return Ok(result);
        }

        [HttpGet("GetJobDetails")]
        public async Task<IActionResult> GetJobDetails()
        {
            //not working
            //var query = $"SELECT j.id,j.dt_created,j.dt_modified,jr.roles,ra.job_roles_id,j.end_date,j.expires,j.job_pre_requisites_id,j.job_title,j.location,j.special_opportunity,j.start_date FROM job j INNER JOIN roles_available ra ON ra.job_id = j.id INNER JOIN roles jr ON jr.id = ra.job_roles_id";
            //var query = $"SELECT j.id,j.dt_created,j.dt_modified,ra.job_roles_id,j.end_date,j.expires,j.job_pre_requisites_id,j.job_title,j.location,j.special_opportunity,j.start_date FROM walkin_portal.job j INNER JOIN walkin_portal.roles_available ra ON j.id = ra.job_id ORDER BY j.id,ra.job_roles_id";
            //var query = $"SELECT r.roles,ra.job_id,ra.job_roles_id,ra.dt_created,ra.dt_modified from roles_available ra INNER JOIN roles r ON r.id = ra.job_roles_id";
            //working
            var query = $"SELECT * from job";
            var result = await _context.Jobs.FromSqlRaw(query).ToListAsync();
            return Ok(result);
            //working end
        }

        [HttpGet("GetJobRoles")]
        public async Task<IActionResult> GetJobRoles()
        {
            var query = $"SELECT * from roles_available";
            var result = await _context.RolesAvailables.FromSqlRaw(query).ToListAsync();
            return Ok(result);
        }
    }
}
