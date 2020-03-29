namespace SuperValue.Utilities.Hashing
{
    public class PasswordHasher
    {
        public static string HashPassword(string clearTextPassword, string saltValue = "")
        {
            return BCrypt.Net.BCrypt.HashPassword(clearTextPassword, saltValue);
        }

        public static bool Verify(string userPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(userPassword, hashedPassword);
        }
    }
}
