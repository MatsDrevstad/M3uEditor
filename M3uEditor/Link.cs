using System;
using System.Collections.Generic;
using System.Text;

namespace M3uEditor
{
    class Link
    {
        public string Info { get; set; }
        public string HttpLink { get; set; }
        public string Line { get; set; }

        public static Link FromFile(string csvLine)
        {
            string[] values = csvLine.Split(Environment.NewLine);
            var link = new Link
            {
                Line = values[0],
            };
            return link;
        }
    }
}
