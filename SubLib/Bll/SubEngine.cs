using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using SubLib.Facade;

namespace SubLib.Bll
{
    public class SubEngine
    {
        public List<SubInfo> LoadSrtFile(string fileName)
        {
            var subs = new List<SubInfo>();
            if (string.IsNullOrEmpty(fileName))
            {
                return subs;
            }
            using (var file = new StreamReader(fileName))
            {
                var subStrs = new List<string>();
                var line = string.Empty;
                int lineNumber = 0;

                while ((line = file.ReadLine()) != null)
                {
                    lineNumber += 1;
                    if (string.IsNullOrEmpty(line))
                    {
                        try
                        {
                            SubInfo sub = new SubInfo(subStrs);
                            subs.Add(sub);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception($"Line {lineNumber}: Exception:{ex.Message}");
                        }

                        subStrs = new List<string>();
                    }
                    else
                    {
                        subStrs.Add(line);
                    }

                }

                if (subStrs.Count > 0)
                {
                    try
                    {
                        var sub = new SubInfo(subStrs);
                        subs.Add(sub);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Line {lineNumber}: Exception:{ex.Message}");
                    }
                }
            }

            return subs;

        }

        public bool SaveFile(List<SubInfo> subs, string fileName)
        {
            using (var file = new StreamWriter(fileName))
            {
                bool addEmptyLine = false;
                foreach (var sub in subs)
                {
                    if (addEmptyLine)
                    {
                        file.WriteLine();
                    }
                    else
                    {
                        addEmptyLine = true;
                    }
                    file.Write(sub.ToString());
                }
            }
            return true;
        }

        public void StripHtml(List<SubInfo> subs)
        {
            foreach (var sub in subs)
            {
                StripHtml(sub);
            }
        }

        public void StripHtml(SubInfo sub)
        {
            for (int i = 0; i < sub.Text.Count; i++)
            {
                sub.Text[i] = StripHtml(sub.Text[i]);
            }

        }
        private string StripHtml(string input)
        {
            return Regex.Replace(input, "<.*?>", string.Empty);
        }

        public void DelayMiliSeconds(List<SubInfo> subs, int delayMiliSeonds)
        {
            foreach (var item in subs)
            {
                DelayMiliSeconds(item, delayMiliSeonds);
            }
        }

        private void DelayMiliSeconds(SubInfo sub, int delayMiliSeonds)
        {
            var difference = TimeSpan.FromMilliseconds(delayMiliSeonds);
            sub.StartTime = sub.StartTime + difference;
            sub.EndTime = sub.EndTime + difference;
        }
    }
}
