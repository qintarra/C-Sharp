
using System;
using System.Linq;

namespace ValidationLibrary
{
    public static class StringOperation
    {
        // Create static method 'GetValidName' with 'nameToValidate' parameter 
        public static string GetValidName(string nameToValidate)
        {
            if (string.IsNullOrEmpty(nameToValidate))
            {
                throw new ArgumentException("Input string is missing or zero-length.");
            }

            var words = nameToValidate.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(w => new string(w.Where(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')).ToArray()))
                .Where(w => !string.IsNullOrEmpty(w))
                .Select(w => w[..1].ToUpper() + w[1..].ToLower())
                .ToList();

            if (words.Count == 0)
            {
                throw new ArgumentException("Output string is empty.");
            }

            var validName = string.Join(" ", words)[..Math.Min(string.Join(" ", words).Length, 50)];

            return validName;
        }
    }
}