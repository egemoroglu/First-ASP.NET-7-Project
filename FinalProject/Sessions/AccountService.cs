using FinalProject.Models;

namespace FinalProject.Sessions
{
    public class AccountService : IAccountService
    {
        private List<Account> accounts;
        public AccountService()
        {
            accounts = new List<Account>()
            {
                new Account()
                {
                    Username = "egemoroglu@hotmail.com",
                    Password = "a"
                }
        };
        }
        public Account Login(string username, string password)
        {
            return accounts.SingleOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
