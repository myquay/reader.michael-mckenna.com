// See https://aka.ms/new-console-template for more information
using CommandLine;
using RssToMd.Infrastructure;

var configuration = Configuration.Load(Environment.GetCommandLineArgs());

Console.WriteLine($"Generating digest for {configuration.Date} ({configuration.TimeZone})");