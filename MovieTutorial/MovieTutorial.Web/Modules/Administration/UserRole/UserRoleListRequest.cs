using Serenity.Services;

namespace MovieTutorial.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}