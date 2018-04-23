using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os2_projekt
{
    class FileRW
    {

        public void createFile(string name, string text)
        {
            string path = @"..\..\..\Files\" + name + ".txt";

            if (!fileExists(path))
            {
                using (StreamWriter streamWriter = File.CreateText(path))
                {
                    streamWriter.WriteLine(text);
                }
            }

        }

        public void writeIntoFile(string name, byte[] text)
        {
            string path = @"..\..\..\Files\" + name + ".txt";

            using (BinaryWriter binaryWriter = new BinaryWriter(new StreamWriter(path, false).BaseStream, Encoding.UTF8))
            {
                binaryWriter.Write(text);
            }
        }

        public string readFile(string name)
        {
           string path = @"..\..\..\Files\" + name + ".txt";

            if (fileExists(path))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                string s = file.ReadToEnd();
                file.Close();
                return s;
            }
           
                return "false";
        }

        public byte[] readFrom(string name)
        {
            string path = @"..\..\..\Files\" + name + ".txt";

            using (BinaryReader reader = new BinaryReader(new StreamReader(path, false).BaseStream, Encoding.UTF8))
                return reader.ReadBytes((int)reader.BaseStream.Length);
        }

        public bool fileExists(string path)
        {
            if (!File.Exists(path))
            {
                return false;
            }
            return true;
        }
    }
}
