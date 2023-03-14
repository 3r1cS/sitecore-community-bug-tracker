namespace SitecoreCommunityBugTracker.Cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Hello, World!");
            Console.WriteLine(args[0]);
        }
    }
}