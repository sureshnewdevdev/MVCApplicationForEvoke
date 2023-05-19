using System.IO;

 File.Create("Suresh.txt");
if (File.Exists("Suresh.txt"))
{
    Console.WriteLine("File Created");
}
else
{
    Console.WriteLine("File modified");
}

var process = from p in System.Diagnostics.Process.GetProcesses()
              select p.ProcessName;

// Write file using StreamWriter
using (StreamWriter writer = new StreamWriter(Path.GetFullPath("Suresh.text")))
{
    foreach (var item in process)
    {
        writer.WriteLine(item);
    }
}
// Read a file
string readText = File.ReadAllText(Path.GetFullPath("Suresh.text"));
Console.WriteLine(readText);

string fileName = Path.GetFullPath("Suresh.text");
FileInfo fi = new FileInfo(fileName);
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
