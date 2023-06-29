using CommandLine.Text;
using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssToMd.Infrastructure
{
    class YamlOptions
    {
        public string? TimeZone { get; set; }

        public string[] Feeds { get; set; }

    }
}
