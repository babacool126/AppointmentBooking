using BCrypt.Net;

namespace AppointmentBooking.Pages.Account
{
    public class PasswordHelper
    {
        public string GenerateHashedPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
