using System.Text.RegularExpressions;

namespace UrlHelper;

public static class UrlHelper
{
    public static string ToUrl(this string text)
    {
        text = text.ToLower();


        return Regex.Replace(text, @"[^0-9a-zA-Z\._]", "");
    }
}