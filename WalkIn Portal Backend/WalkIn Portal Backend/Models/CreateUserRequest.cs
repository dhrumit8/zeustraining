namespace WalkIn_Portal_Backend.Models
{
    public class CreateUserRequest
    {
        public UserDetail User { get; set; }
        public bool IndustrialDesigner { get; set; }
        public bool SoftwareEngineer { get; set; }
        public bool SoftwareQualityEngineer { get; set; }
        public string Password { get; set; }
        public EducationalQualification educationalQualification { get; set; }
        public string professionalQualification { get; set; }
        public FresherQualification fresherQualification { get; set; }
        public ExperiencedQualification experiencedQualification { get; set; }
        public bool JavascriptFresher { get; set; }
        public bool AngularJSFresher { get; set; }
        public bool ReactFresher { get; set; }
        public bool NodeJSFresher { get; set; }
        public bool JavascriptExpFam { get; set; }
        public bool AngularJSExpFam { get; set; }
        public bool ReactExpFam { get; set; }
        public bool NodeJSExpFam { get; set; }
        public bool JavascriptExpExpert { get; set; }
        public bool AngularJSExpExpert { get; set; }
        public bool ReactExpExpert { get; set; }
        public bool NodeJSExpExpert { get; set; }
    }
}
