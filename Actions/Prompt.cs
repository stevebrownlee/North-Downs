using System;

namespace Trestlebridge.Actions {
    internal class Prompt {
        public static int Query (string prompt) {
            Console.WriteLine ();
            Console.WriteLine (prompt);

            Console.Write ("> ");
            return Int32.Parse (Console.ReadLine ());
        }
    }
}