﻿using InsideLogger;
using System;
using System.IO;
using System.Text;

namespace InsideLog
{   
    public class InsideLogger
    {
        //Asynchronous output to the console
        public async void InfoAsync<T>(T text)
        {
            string TextTime = $"{DateTime.Now}|{text}";
            TextTime.Split("");
            await Console.Out.WriteLineAsync(TextTime);
        }

        //Asynchronous output of a string to the console
        public async void InfoAsync()
        {
           await Console.Out.WriteLineAsync();
        }

        //Asynchronous writing to files
        public async void WriteDataFileAsync(string TextToFile, string File)
        {
            using (FileStream FileSteaming = new FileStream(File, FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(TextToFile);
                await FileSteaming.WriteAsync(buffer, 0, buffer.Length);
            }
        }

        //Asynchronous output of information to the console with color
        public async void InfoAsync<T>(T text, Color color)
        {
            switch (color)
            {
                case Color.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.Black:
                    Console.ForegroundColor = ConsoleColor.Black;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.Gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkBlue:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkGreen:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkYellow:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkCyen:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkMagneta:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkRed:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.Cyen:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkGrey:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    await Console.Out.WriteLineAsync($"{DateTime.Now}|{text}");
                    break;
                default:
                    break;
            }
            Console.ResetColor();
        }

        //Asynchronous error output to the console
        public async void ErrorAsync<T>(T TextError)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            await Console.Out.WriteLineAsync($"{DateTime.Now}|{TextError}");
            Console.ResetColor();
        }

        //Asynchronous warning output to the console
        public async void WarningAsync<T>(T TextWarning)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            await Console.Out.WriteLineAsync($"{DateTime.Now}|{TextWarning}");
            Console.ResetColor();
        }

        //Outputting information to the console
        public void Info<T>(T text)
        {
            string TextTime = $"{DateTime.Now}|{text}";
            TextTime.Split("");
            Console.WriteLine(TextTime);
        }

        //String output to console
        public void Info()
        {
            Console.WriteLine();
        }

        //Writing information to a file
        public void WriteDataFile(string TextToFile, string File)
        {
            using (FileStream FileSteaming = new FileStream(File, FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(TextToFile);
                FileSteaming.Write(buffer, 0, buffer.Length);
            }
        }

        //Output information to the console with color
        public void Info<T>(T text, Color color)
        {
            switch (color)
            {
                case Color.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.Black:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.Gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkBlue:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkGreen:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkYellow:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkCyen:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkMagneta:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkRed:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.Cyen:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                case Color.DarkGrey:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"{DateTime.Now}|{text}");
                    break;
                default:
                    break;
            }
            Console.ResetColor();           
        }

        //Error output to console
        public void Error<T>(T TextError)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{DateTime.Now}|{TextError}");
            Console.ResetColor();
        }

        //Outputting a warning to the console
        public void Warning<T>(T TextWarning)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{DateTime.Now}|{TextWarning}");
            Console.ResetColor();
        }
    }
}
