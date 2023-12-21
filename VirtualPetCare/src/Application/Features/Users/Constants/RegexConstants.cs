using System.Text.RegularExpressions;

namespace Application.Features.Users.Constants;

public static partial class RegexConstants
{
    [GeneratedRegex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}")]
    public static partial Regex PhoneNumberRegex();
}