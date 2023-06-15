using FinalProject.Models;

namespace FinalProject.Sessions
{
    public class AdminService : IAdminService
    {
        private List<Admin> admins;
        public AdminService()
        {
            admins = new List<Admin>()
            {
                new Admin()
                {
                    username = "egemoroglu@hotmail.com",
                    password = "a"
                }
                
        };
        }
        public Admin Login(string username, string password)
        {
            return admins.SingleOrDefault(x => x.username == username && x.password == password);
        }
    }
}
