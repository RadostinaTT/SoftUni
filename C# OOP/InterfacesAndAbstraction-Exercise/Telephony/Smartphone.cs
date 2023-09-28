namespace Telephony
{
    using System.Linq;
    public class Smartphone : ICaller, IBrowser
    {
        public string Browsing(string url)
        {
            if (url.Any(char.IsDigit))
            {
                return "Invalid URL";
            }
            return $"Browsing: {url}";
        }

        public string Calling(string number)
        {
            if (!number.All(char.IsDigit))
            {
                return "Invalid number!";
            }
            return $"Calling... {number}";
        }
    }
}
