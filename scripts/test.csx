#r "nuget: AutoMapper, 10.0.0"

using System;
using System.Threading.Tasks;
using System.IO;
using AutoMapper;

//hi

Console.WriteLine(typeof(MapperConfiguration));
string inputPath = Args[0];
string outputPath = Args[1];

Console.WriteLine($"Input path: {inputPath}");
Console.WriteLine($"Output path: {outputPath}");

var inputText = File.ReadAllText($"{inputPath}/testInputFile.txt");
Console.WriteLine(inputText);

await Task.Delay(10);

var content = $"{inputText} Dan";

File.WriteAllText($"{outputPath}/output.txt", content);

Console.WriteLine("Script finished.");

