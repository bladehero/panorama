using Microsoft.AspNetCore.Http;
using System.Text;
using System.Threading.Tasks;

namespace OdekuTour.Middlewares
{
    public class TokenMiddleware
    {
        private readonly RequestDelegate _next;

        internal const string _key = "__auth__";
        internal static string Login;
        internal static string Password;

        public TokenMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            bool isAdminArea = context.Request.Path.HasValue ? context.Request.Path.Value.Contains("admin") || context.Request.Path.Value.Contains("Admin") : false;
            bool isLoginMethod = context.Request.Path.HasValue ? context.Request.Path.Value.Contains("login") || context.Request.Path.Value.Contains("Login") : false;
            string hash = GetMD5Hash(Login, Password);
            if (isLoginMethod)
            {
                if (context.Request.Cookies[_key] == hash)
                {
                    context.Response.Redirect("home/index");
                }
                else
                {
                    await _next.Invoke(context);
                }
            }
            else if ((isAdminArea && context.Request.Cookies[_key] == hash) || !isAdminArea)
            {
                await _next.Invoke(context);
            }
            else
            {
                context.Response.StatusCode = 404;
            }
        }

        public static string GetMD5Hash(string login, string password)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(login + password + _key);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                var sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
