using System.Text.RegularExpressions;

namespace USTest.BLL.Extensions;

public static class StringExtensions
{
    public static int GetLocationId(string url)
    {
        Regex regex = new Regex(@"\d*$");
        int id = Convert.ToInt32(regex.Match(url).Value);
        return id;
    }
}