namespace Diphda.Domain.Account.Models
{
    public readonly struct Username
    {
        private readonly string value;

        public string Value { get { return this.value; } }

        public Username(string value)
        {
            this.value = value ?? string.Empty;
        }

        public static implicit operator Username(string value)
        {
            return new Username(value);
        }

        public static bool operator ==(Username leftUsername, Username rightUsername)
        {
            return leftUsername.value == rightUsername.value;
        }

        public static bool operator !=(Username leftUsername, Username rightUsername)
        {
            return leftUsername.value != rightUsername.value;
        }
    }
}