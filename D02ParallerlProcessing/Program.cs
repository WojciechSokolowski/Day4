// See https://aka.ms/new-console-template for more information
using D02ParallerlProcessing;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

// parallel processing and asynchronous processing


ParallelTesting pt = new ParallelTesting();

Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
pt.Task1();
pt.Task2();
stopwatch.Stop();

Console.WriteLine($"Sequential execuution took {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Restart();
Parallel.Invoke(() => pt.Task1(), () => pt.Task2());
stopwatch.Stop();

Console.WriteLine($"Parallel execuution took {stopwatch.ElapsedMilliseconds} ms");


int numberofCores = Environment.ProcessorCount;
Console.WriteLine($"Number of logical processor: {numberofCores}");