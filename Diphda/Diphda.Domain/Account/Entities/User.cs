namespace Diphda.Domain.Account
{
    public sealed class User 
    {
        private readonly string username;

        private readonly string password;

        private bool verified;

        public string Username { get { return username; } }

        public string Password { get { return password; } }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}