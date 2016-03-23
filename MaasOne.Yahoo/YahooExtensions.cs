namespace YahooManaged.Services
{  
    public partial class YahooExtensions
    {
        public static byte[] StringToAscii(string s)
        {
            return System.Text.Encoding.ASCII.GetBytes(s);
        }
    }
}
