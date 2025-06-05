namespace Knoq.Extensions.Authentication
{
    public sealed class TraqAuthenticationInfo
    {
        public string? CookieAuthToken { get; private set; }

        public string? Username { get; private set; }
        public string? Password { get; private set; }

        public void UseCookieAuthentication(string cookieAuthToken)
        {
            ArgumentNullException.ThrowIfNull(cookieAuthToken);
            CookieAuthToken = cookieAuthToken;
            Username = null;
            Password = null;
        }

        public void UsePasswordAuthentication(string username, string password)
        {
            ArgumentNullException.ThrowIfNull(username);
            ArgumentNullException.ThrowIfNull(password);
            Username = username;
            Password = password;
            CookieAuthToken = null;
        }
    }
}
