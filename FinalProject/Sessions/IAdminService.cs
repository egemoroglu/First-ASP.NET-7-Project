using FinalProject.Models;

namespace FinalProject.Sessions
{
    public interface IAdminService
    {
        public Admin Login(string username, string password);
    }
}
