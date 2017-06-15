using System;

namespace VILICVANE.ForceUTF8
{
    public class Output
    {
        public static void Info(string message)
        {
            message = "[Info] " + message;
            WriteToOutput(message);
        }

        public static void Warn(string message)
        {
            message = "[Warn] " + message;
            WriteToOutput(message);
        }

        public static void Error(string message)
        {
            message = "[Error] " + message;
            WriteToOutput(message);
        }

        private static void WriteToOutput(string message)
        {
            Console.WriteLine(message);
        }
    }
}