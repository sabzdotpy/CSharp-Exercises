using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_15
{
    internal class FileOps
    {

        string path;

        public FileOps(string path)
        {
            this.path = path;
        }

        public void ReadAFile()
        {
            if (File.Exists(this.path))
            {
                string text = File.ReadAllText(this.path);
                Console.WriteLine($"File Content: {text}");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            
        }

        public void WriteAFile(string text) {
            if (!File.Exists(this.path))
            {
                File.Create(this.path);
                File.WriteAllText(this.path, text);
                Console.WriteLine($"Content written to new file {this.path}");
            }
            else
            {
                File.AppendAllText(this.path, text);
                Console.WriteLine($"Content appended to existing file {this.path}");
            }
            
        }


        public void StreamWrite(string text)
        {
            Console.WriteLine("writing stream to file");
            //StreamWriter streamWriter = new StreamWriter(this.path);
            //streamWriter.WriteLine(text);
            //streamWriter.Close();

            
            using (StreamWriter streamWriter = new StreamWriter(this.path))
            {
                streamWriter.WriteLine(text);
            }
        }

        public void StreamRead()
        {
            Console.WriteLine("reading stream from file");

            using (StreamReader streamReader = new StreamReader(this.path))
            {
                string text = streamReader.ReadToEnd();
                Console.WriteLine($"Stream text: {text}");
            }
        }

    }
}
