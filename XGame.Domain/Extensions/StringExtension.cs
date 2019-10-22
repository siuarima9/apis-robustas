using System.Text;

namespace XGame.Domain.Extensions
{
    public static class StringExtension
    {
        public static string ConvertToMD5(this string Senha)
        {
            if (string.IsNullOrEmpty(Senha)) return "";

            var senha = (Senha += "|ae6e350e-b968-453d-9608-c1b88f9d5616");
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(senha));
            var sbString = new StringBuilder();
            foreach(var t in data)
            {
                sbString.Append(t.ToString("x2"));
            }

            return sbString.ToString();
        }
    }
}
