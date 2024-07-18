// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace hello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0) 
            {
                StringBuilder output = new(); 
                string command = $"stat -e cache-references,cache-misses,cycles,instructions,branches,faults,migrations ./hello 1";
                using (Process perfProcess = new Process())
                {
                    perfProcess.StartInfo.FileName = "perf";
                    perfProcess.StartInfo.Arguments = command;
                    perfProcess.StartInfo.UseShellExecute = false;
                    perfProcess.StartInfo.RedirectStandardOutput = true;
                    perfProcess.StartInfo.RedirectStandardError = true;
                    perfProcess.StartInfo.CreateNoWindow = true;
                    perfProcess.Start();
                    output.AppendLine(perfProcess.StandardOutput.ReadToEnd());
                    output.AppendLine(perfProcess.StandardError.ReadToEnd());
                    perfProcess.WaitForExit();
                    File.WriteAllText("./Perf.stat", output.ToString());
                }

                System.Console.WriteLine("Application started.");
            }

            else
            {
                int foo = new int();
                for (long i = 0; i < 100_000_000; i++)
                {
                    foo = 1;
                }
            }

            //CreateHostBuilder(args).Build().Run();
            // 1. Start the perf process.
            // 2. Start the loop of setting vals. 
            // 3. Stop the perf process.
        }

    }
}
