namespace DependencyInjectionApp
{
    public static class StringExtensions
    {

        public static string Hello(this string inputString) {

            return $"Hello , {inputString.ToUpper()}";
        }

    }
}
