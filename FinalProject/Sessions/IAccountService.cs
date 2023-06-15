using FinalProject.Models;
namespace FinalProject.Sessions
{
    public interface IAccountService
    {
        public Account Login(string username, string password);
    }
}
