﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AD_Splitter
{
    class LineProcessor
    {
        public void ProcessLineByLine(string inputFile, string indexFileName, string outputFolder, string separator)
        {
            StreamWriter indexFile = new StreamWriter(Path.Combine(outputFolder, indexFileName + ".html"), true, Encoding.UTF8);
            indexFile.WriteLine(@"<html> 
                                    <body> 
                                        <h1>Content</h1>
                                        <br />");
            int fileCount = 0;
            StreamWriter childFile = null;
            string childFileName = String.Empty;
            foreach (var line in ReadFrom(inputFile))
            {
                if (line.StartsWith(separator)) //new child file
                {

                    ClosePreviousChildFile(indexFileName, indexFile, childFile, childFileName);
                    //create new child file
                    childFileName = Path.Combine(outputFolder,
                                                String.Format("{0}-{1}.html",
                                                GetPrefixPart(indexFileName, ++fileCount),
                                                CleanFileName(line)));
                    childFile = new StreamWriter(childFileName, append: true, encoding: Encoding.UTF8);
                    childFile.WriteLine(@"<html> 
                                            <body>");
                    // Link to Home- TOC file at top
                    childFile.WriteLine(String.Format("<a href='{0}'>Home</a> <br/>", indexFileName + ".html"));
                    childFile.WriteLine(String.Format("<h1>{0}</h1>", line.Replace(separator, "")));
                }
                else // keep writing to newly created child file
                {
                    childFile.WriteLine("<br />" + line);
                }
            }

            ClosePreviousChildFile(indexFileName, indexFile, childFile, childFileName);

            indexFile.WriteLine(@"</body> 
                                    </html>");
            indexFile.Close();
        }

        private void ClosePreviousChildFile(string indexFileName, StreamWriter indexFile, StreamWriter childFile, string childFileName)
        {
            if (childFile != null) //close previous child file
            {
                childFile.WriteLine(String.Format("<a href='{0}'>Home</a> <br/>", indexFileName + ".html"));
                childFile.WriteLine(@"</body> 
                                                 </html>");
                childFile.Close();
                indexFile.WriteLine(String.Format("<a href='{0}'>{0}</a> <br/>", Path.GetFileName(childFileName)));
            }
        }

        private static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line.
                                 Trim().
                                 Replace("\r\n\r\n", Environment.NewLine);
                }
            }
        }

        private string GetPrefixPart(string prefix, int Count)
        {
            if (Count < 10)
                return String.Format("{0}000{1}", prefix, Count);
            else if (Count < 100)
                return String.Format("{0}00{1}", prefix, Count);
            else if (Count < 1000)
                return String.Format("{0}0{1}", prefix, Count);
            else
                return prefix + Count;

        }

        private string CleanFileName(string fileName)
        {
            if (fileName == null || fileName.Length == 0) return string.Empty;
            var sb = new StringBuilder();
            foreach (char c in fileName)
                if (Char.IsLetter(c) || char.IsWhiteSpace(c))
                    sb.Append(c);
            return sb.ToString().Trim();
        }
    }
}