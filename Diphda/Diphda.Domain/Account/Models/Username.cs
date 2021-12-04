namespace Diphda.Domain.Account.Models
{
    public class Username
    {
        private readonly string value;

        public string Value { get { return this.value; } }

        public Username(string value)
        {
            this.value = value;
        }

        public static implicit operator Username(string value)
        {
            return new Username(value);
        }
    }
}