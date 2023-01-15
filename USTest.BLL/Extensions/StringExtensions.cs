using System.Text.RegularExpressions;

namespace USTest.BLL.Extensions;

public static class StringExtensions
{
    public static int GetLocationId(this string url)
    {
        Regex regex = new Regex(@"\d*$");
         if (regex.Match(url).Value == "")
             return 0;
        return Convert.ToInt32(regex.Match(url).Value);
    }

    public static string ReplaceSpaceInString(this string str)
    {
        return str.Replace(" ", "%20");
    }
}