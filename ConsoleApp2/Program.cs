internal class Program
{
    private static void Main(string[] args)
    {
        string word = "Hello";

        string withiutFirst = word.Substring(1);

        string result = withoutFirst + word[0];

        Console.WriteLine(result);
    }
}