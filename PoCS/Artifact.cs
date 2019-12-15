using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.CompilerServices;

namespace PoCS
{
    class Artifact
    {
        public static void CopyStream(StreamReader src, StreamWriter dest)
        {
            var buffer = new char[Int32.MaxValue];
            int len;
            while ((len = src.Read(buffer, 0, buffer.Length)) > 0)
            {
                dest.Write(buffer, 0, len);
            }
        }
        public static void ArtifactGenerator()
        {
            DirectoryInfo[] cDirs = new DirectoryInfo(@".\").GetDirectories();
            using (StreamWriter sw = new StreamWriter("PoCS." + typeof(ArgumentNullException).ToString() + ".dll"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }

            string line = "";
            using (StreamReader sr = new StreamReader("PoCS." + typeof(ArgumentNullException).ToString() + ".dll"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}