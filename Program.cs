namespace MethodOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FormatName("Mary", "Jacksson"));
            Console.WriteLine(FormatName("Mary", "Jane", "Jacksson"));
            Console.WriteLine(FormatName("Mary", "Jacksson", true));

        }

        static string FormatName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
   
    static string FormatName(string firstName, string middle, string lastName)
        {
            return $"{firstName} {middle} {lastName}";
        }    
   
    static string FormatName(string firstName, string lastName, bool uppercase)
        {
            var full = $"{firstName} {lastName}";
            return uppercase ? full.ToUpper() : full ;
        }    
    
    }
}
