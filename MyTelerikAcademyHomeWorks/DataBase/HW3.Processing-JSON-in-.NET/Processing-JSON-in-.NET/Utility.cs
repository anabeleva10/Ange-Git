﻿namespace Processing_JSON_in_.NET
{
    using System;
    using System.IO;
    
    internal class Utility
    {
        public static string GetFileContent(string rssDownloadLocation)
        {
            if (!File.Exists(rssDownloadLocation))
            {
                throw new FileNotFoundException("File does not exist: " + rssDownloadLocation);    
            }

            string textContent;
            using (var reader = new StreamReader(rssDownloadLocation))
            {
                textContent = reader.ReadToEnd();    
            }

            return textContent;
        }
    }
}
