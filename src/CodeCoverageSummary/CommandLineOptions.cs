﻿using CommandLine;

namespace CodeCoverageSummary
{
    public class CommandLineOptions
    {
        [Value(index: 0, Required = true, HelpText = "Code coverage file to analyse.")]
        public string Filename { get; set; }

        [Option(shortName: 'f', longName: "format", Required = false, HelpText = "Output Format.", Default = "text")]
        public string Format { get; set; }
    }
}