using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines =
            System.IO.File.ReadAllLines(@"C:\Users\jungi\Desktop\words.txt");//read everything
            System.IO.File.WriteAllLines(@"C:\Users\jungi\Desktop\words.txt", lines);//copy a file from above
            StreamReader stream = File.OpenText(@"C:\Users\jungi\Desktop\words.txt");
            
            // String line = stream.ReadLine();
            // Console.WriteLine(line); //read the first line and write it. a as the first line in the text
            // String line2 = stream.ReadLine();
            // Console.WriteLine(line2);//read the following line and write it.a and aa
            // if(line.StartsWith("a")){
            //     Console.WriteLine(line);
            // }
            // stream.Close();// this one gives me a character "a"
            // foreach (String line in lines)
            // {
            //     Console.WriteLine(line);//Console has all lines of the text file.
            // }

            //I want to write into the text file.
            FileStream outStream = File.OpenWrite(@"C:\Users\jungi\Desktop\words2.txt");//
            StreamWriter s = new StreamWriter(outStream);
            String line = stream.ReadLine();
            while (line != null)
            {
            // Console.WriteLine(line);//write in the console
                s.WriteLine(line);//write in the file
                line = stream.ReadLine();//read and write all lines of the text
            }

            s.Close();
            stream.Close();
            //how to copy a picture
            FileStream picReader = File.OpenRead(@"C:\Users\jungi\Desktop\cat.png");//
            FileStream picWriter = File.OpenWrite(@"C:\Users\jungi\Desktop\cat1.png");
            
int b1 = picReader.ReadByte();
 while (b1 != -1)
            {
            // Console.WriteLine(line);//write in the console
                picWriter.WriteByte((byte)b1);//write in the file
                b1 = picReader.ReadByte();//read and write all lines of the text
            }

            picReader.Close();
            picWriter.Close();
        }
    }
}
//homework-hangman
//how to figure out which words to guess
//array of words ahead of time
//randomly guess words and ...
//pick a word randomly from a file
//let users to guess
//users get the hint
//


