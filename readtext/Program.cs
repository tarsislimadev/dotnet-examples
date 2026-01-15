using System;
using System.IO;

try
{
  string content = File.ReadAllText("example.txt");
  Console.WriteLine(content);
}
catch (IOException e)
{
  Console.WriteLine("The file could not be read:");
  Console.WriteLine(e.Message);
}
