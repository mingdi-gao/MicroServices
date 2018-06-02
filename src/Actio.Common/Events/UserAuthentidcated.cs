namespace Actio.Common.Events
{
    public class UserAuthentidcated : IEvnet
    {
        public string Email { get; }

        protected UserCreated(){

        }

        public UserAuthentidcated(string email)
        {
            Email = email;
        }
    }
}