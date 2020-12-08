﻿using System;
using System.Collections.Generic;
using System.Text;
using CommandLine;

namespace CP77Tools
{
    [Verb("archive", HelpText = "CyberPunk 77 Archive Tools.")]
    public class ArchiveOptions
    {
        [Option(HelpText = "Specify the archive path.", Required = true)]
        public string path { get; set; }

        [Option(HelpText = "Dump info.", Required = false)]
        public bool dump { get; set; }

        [Option(HelpText = "Extract files.", Required = false)]
        public bool extract { get; set; }
    }

    [Verb("dbg", HelpText = "CyberPunk 77 Archive Tools.")]
    public class DbgOptions
    {
        [Option(HelpText = "Specify the archive path.", Required = true)]
        public string path { get; set; }

    }
}