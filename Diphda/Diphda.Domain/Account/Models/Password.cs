namespace Diphda.Domain.Account
{
    public readonly struct Password
    {
        private readonly string value;

        public string Value { get { return value; } }

        public Password(string value)
        {
            this.value = value;    
        }

        public static implicit operator Password(string value)
        {
            return new Password(value); // TODO: set validations here to create a new instance of password.
        }
    }
}