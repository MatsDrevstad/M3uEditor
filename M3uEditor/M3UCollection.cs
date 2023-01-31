using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace M3uEditor
{
    class M3UCollection
    {
        public List<Link> linksRaw = new List<Link>();
        public List<Link> links = new List<Link>();
        public List<Link> filter = new List<Link>();
        internal string[] GetFileName()
        {
            string[] fileArray = Directory.GetFiles(M3uApplication.FolderName);
            return fileArray;
        }
        internal void AddFilterData(string path)
        {
            try
            {
                filter = File.ReadAllLines(path).Select(v => Link.FromFile(v)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal void AddFileData(string path)
        {
            try
            {
                linksRaw = File.ReadAllLines(path).Skip(1).Select(v => Link.FromFile(v)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        internal void DisplayDistinct()
        {
            IEnumerable<Link> noduplicates =
            links.Distinct(new M3UCollectionComparer());

            foreach (var link in noduplicates)
                Console.WriteLine(link.Info);
            Console.ReadLine();
        }
        internal void CreateM3U()
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(M3uApplication.FolderName + "upload.m3u"))
            {
                file.Write("#EXTM3U\n");
                foreach (Link line in links)
                {
                    file.Write(line.Info + "\n");
                    file.Write(line.HttpLink + "\n");
                }
            }
        }

        internal void Filter(List<Link> filterList)
        {
            foreach (var item in filterList)
            {
                Console.WriteLine(item.Line + "\t" +
                    links.RemoveAll(p => p.Info.Contains("|" + item.Line)));
            }
            foreach (var item in filterList)
            {
                Console.WriteLine(item.Line + "\t" +
                    links.RemoveAll(p => p.Info.Contains("| " + item.Line)));
            }
            foreach (var item in filterList)
            {
                Console.WriteLine(item.Line + "\t" +
                    links.RemoveAll(p => p.Info.Contains(item.Line + " |")));
            }
            foreach (var item in filterList)
            {
                Console.WriteLine(item.Line + "\t" +
                    links.RemoveAll(p => p.Info.Contains(item.Line + "|")));
            }
        }
    }
}
