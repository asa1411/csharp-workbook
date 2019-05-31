using System;
using System.IO;
namespace Files
{
   public  class Program
    {
     public   static void Main(string[] args)
        {
            // StreamReader stream = File.OpenText(@"C:\Users\jungi\Desktop\example.txt");
            //I want to write into the text file.
        FileStream outStream = File.OpenWrite(@"C:\Users\jungi\Desktop\example.txt");
           StreamWriter s = new StreamWriter(outStream);
            String line = s.ReadLine();
            //  while (line != null)
            // {
            //  Console.WriteLine(line);//write in the console
           s.WriteLine(line);//write in the file
           line = stream.ReadLine();//read and write all lines of the text
            
		}
    }
}