using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GoHealth {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("hello");
            string input = File.ReadAllText (@"../Input.txt");

            StringBuilder sb = new StringBuilder ();

            foreach (char c in input) {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ') {
                    sb.Append (c);
                }
            }

            input = sb.ToString ();

            string[] splitted = input.Split (null);

            Dictionary<string, int> results = new Dictionary<string, int> ();

            for (int TotalWords = 0; TotalWords < splitted.Length - 1; TotalWords++) {

                string TryWord = splitted[TotalWords] + " " + splitted[TotalWords + 1];

                if (results.ContainsKey (TryWord)) {
                    results[TryWord] = results[TryWord] + 1;
                } else {
                    results.Add (TryWord, 1);
                }
            }

            foreach (KeyValuePair<string, int> kvp in results) {
                Console.WriteLine ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}