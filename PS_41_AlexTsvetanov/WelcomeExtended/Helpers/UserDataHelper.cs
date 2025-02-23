using WelcomeExtended.Data;
using Welcome.Model;

namespace WelcomeExtended.Helpers
{
    public static class UserDataHelper
    {
        public static bool ValidateCredentials(this UserData userData, string name, string password)
        {
            if (name.Length == 0)
            {
                throw new ArgumentOutOfRangeException("The name cannot be empty");
            }
            if (password.Length == 0)
            {
                throw new ArgumentOutOfRangeException("The password cannot be empty");
            }
            return userData.ValidateUser(name, password);
        }
        public static User GetUser(this UserData userData, string name, string password)
        {
            if (!userData.ValidateCredentials(name, password))
            {
                throw new ArgumentOutOfRangeException("User credentials not found.");
            }
            return userData.GetUser(name, password);
        }
    }
}
