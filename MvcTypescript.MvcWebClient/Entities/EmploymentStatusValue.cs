using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcTypescript.MvcWebClient.Entities
{
    public static class EmploymentStatusValue
    {
        public const char Active = 'A';
        public const char Inactive = 'I';
        public const char Terminated = 'T';
        public const char Leave = 'L';

        public static IEnumerable<char> AllValues = new[] { Active, Inactive, Terminated, Leave };

        public static bool IsValidValue(char value)
        {
            return AllValues.Contains(value);
        }

        private static Dictionary<char, string> codeLookup = new Dictionary<char, string>
        {
            {Active, "Active"},
            {Inactive, "Inactive"},
            {Terminated, "Terminated, Retired or Layoff"},
            {Leave, "Leave"}
        };
        public static IDictionary<char, string> GetCodeLookup()
        {
            return codeLookup;
        }

        public static string GetCodeLookupAsString()
        {
            return String.Join(", ", codeLookup.Select(s => String.Format("'{0}' ({1})", s.Key, s.Value)));
        }

    }
}