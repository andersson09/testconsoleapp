using System;
using System.Threading.Tasks;
using System.IO;

string inputPath = Args[0];
string outputPath = Args[1];

Console.WriteLine($"Input path: {inputPath}");
Console.WriteLine($"Output path: {outputPath}");

var inputText = File.ReadAllText($"{inputPath}/testInputFile.txt");
Console.WriteLine(inputText);

var inputText2 = File.ReadAllText($"{inputPath}/testInputFile.txt");
Console.WriteLine(inputText2);

await Task.Delay(2000);

var content = "Hello Dan.";

File.WriteAllText($"{outputPath}/output.txt", content);
File.WriteAllText($"{outputPath}/output2.txt", "abc");


Console.WriteLine("Script finished.");

