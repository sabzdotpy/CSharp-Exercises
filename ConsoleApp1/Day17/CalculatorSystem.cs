using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day17
{

    class CalcException : Exception
    {
        public CalcException(string message) : base($"Exception in Calculator System: {message}") { }
    }

    class Paths
    {
        protected static string base_path = "D:/Code/C#/ConsoleApp1/ConsoleApp1/Day17";
        protected static string operations_folder_name = "Operations";
        protected static string error_folder_name = "Logs";
        protected static string backup_folder_name = "Backup";
    }

    class FileLogger : Paths
    {

        public static void Log(string operation)
        {
            if (!Directory.Exists($"{base_path}/{operations_folder_name}"))
            {
                Directory.CreateDirectory($"{base_path}/{operations_folder_name}");
            }
            string caller = new StackFrame(1, true).GetMethod()!.Name;
            // dir exists. write file.
            File.WriteAllText($"{base_path}/{operations_folder_name}/operation_{DateTime.Now:dd-MMM-yy_HH-mm-ss_tt}.txt", $"{operation} - Called by '{caller}' Function");

            Console.WriteLine($"Log: {operation}");
        }

        public static void Error(Exception error)
        {
            if (!Directory.Exists($"{base_path}/{error_folder_name}"))
            {
                Directory.CreateDirectory($"{base_path}/{error_folder_name}");
            }
            // dir exists. write file.
            File.WriteAllText($"{base_path}/{error_folder_name}/error_{DateTime.Now:dd-MMM-yy_HH-mm-ss_tt}.txt", $"{error.Message}\n{error.StackTrace}");

            Console.WriteLine($"Error Log: {error}");
        }

    }

    class BackupHelper : Paths
    {
        public BackupHelper()
        {
            if (!Directory.Exists($"{base_path}/{backup_folder_name}"))
            {
                Console.WriteLine("Creating backup directory");
                Directory.CreateDirectory($"{base_path}/{backup_folder_name}");
            }
        }

        private bool IsFile(string path)
        {
            return File.Exists(path);
        }

        private bool IsFileAndLessThan1MB(string path)
        {
            if (IsFile(path))
            {
                long length = new System.IO.FileInfo(path).Length;
                return (length < 1 * 1024 * 1024);
            }
            return false;
        }

        private bool MakeBackup(string from)
        {
            try
            {
                File.Move(from, $"{base_path}/{backup_folder_name}/{Path.GetFileName(from)}");
                return true;
            }
            catch (Exception ex)
            {
                FileLogger.Error(ex);
                return false;
            }
        }

        public void StartBackup()
        {
            Console.WriteLine("Starting backup.");
            string[] fileEntries = Directory.GetFiles($"{base_path}/{operations_folder_name}");
            foreach (string fileName in fileEntries)
            {
                Console.WriteLine($"Processing {fileName}");
                if (IsFileAndLessThan1MB(fileName))
                {
                    MakeBackup(fileName);
                }
            }
            Console.WriteLine("Completing backup.");
        }

    }


    internal class CalculatorSystem
    {

        public CalculatorSystem() { }

        public int Add(int a, int b)
        {
            FileLogger.Log($"{a} + {b} = {a + b}");
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            FileLogger.Log($"{a} + {b} + {c} = {a + b + c}");
            return a + b + c;
        }

        public int Sub(int a, int b)
        {
            FileLogger.Log($"{a} - {b} = {a - b}");
            return a - b;
        }

        public int Sub(int a, int b, int c)
        {
            FileLogger.Log($"{a} - {b} - {c} = {a - b - c}");
            return a - b - c;
        }

        public int Mul(int a, int b)
        {
            FileLogger.Log($"{a} * {b} = {a - b}");
            return a * b;
        }

        public int Div(int a, int b)
        {
            try
            {
                if (b == 0) throw new CalcException("Trying to divide by zero");
                FileLogger.Log($"{a} / {b} = {a / b}");
                return a / b;
            }
            catch (CalcException ce)
            {
                Console.WriteLine("Encountered error when dividing, see error log");
                FileLogger.Error(ce);
                return -1;
            }
        }

    }
}
