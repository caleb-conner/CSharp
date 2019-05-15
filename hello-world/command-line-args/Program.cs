using System;

namespace command_line_args
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
              Console.WriteLine($"Hello, {args[0]}!");
            }
        }
    }
}
