using System.Diagnostics;

[DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
internal class ProgramBase
{
    private static void Main(string[] args)
    {
        TEST();

        static void TEST()
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            void f()
            {
                Console.WriteLine("HAIIIIIIIIIIIIIIIIIIIIII");
            }
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}