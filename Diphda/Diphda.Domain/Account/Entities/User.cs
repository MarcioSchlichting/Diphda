namespace Diphda.Domain.Account
{
    using Diphda.Domain.Abstractions;

    public sealed class User : BaseEntity
    {
        private readonly string username;

        private readonly Password password;

        private bool active;

        public string Username { get { return this.username; } }

        public Password Password { get { return this.password; } }

        public bool Active { get { return this.active; } }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}