using System;
using System.Collections.Generic;
using System.Text;

namespace SubLib.Facade
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/SubRip
    /// The SubRip file format, as reported on the Matroska multimedia container format website, 
    /// is "perhaps the most basic of all subtitle formats."
    /// [9] SubRip (SubRip Text) files are named with the extension .srt, 
    /// and contain formatted lines of plain text in groups separated by a blank line. 
    /// Subtitles are numbered sequentially, starting at 1. 
    /// The time code format used is hours:minutes:seconds,milliseconds with time units fixed 
    /// to two zero-padded digits and fractions fixed to three zero-padded digits (00:00:00,000). 
    /// The fractional separator used is the comma, since the program was written in France.
    /// 
    /// Example:
    ///   168
    ///   00:20:41,150 --> 00:20:45,109
    ///  - How did he do that?
    ///  - Made him an offer he couldn't refuse.
    /// 
    /// </summary>
    public class SubInfo
    {
        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public List<string> Text { get; set; }

        public SubInfo()
        {
            Text = new List<string>();
        }

        public SubInfo(List<string> strs)
        {
            Text = new List<string>();
            var id = 0;
            int.TryParse(strs[0], out id);

            var times = strs[1].Split(new string[] { "-->" }, StringSplitOptions.RemoveEmptyEntries);
            var start = times[0].ToTimeSpan();
            var end = times[1].ToTimeSpan();

            List<string> text = new List<string>();
            if (strs.Count > 2)
            {
                for (var i = 2; i < strs.Count; i++)
                {
                    text.Add(strs[i]);
                }
            }
            ParseSubInfo(id, start, end, text);

        }

        public void ParseSubInfo(int id, TimeSpan startTime, TimeSpan endTime, List<string> text)
        {
            Id = id;
            StartTime = startTime;
            EndTime = endTime;
            Text.AddRange(text);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Id.ToString());
            sb.AppendLine($"{StartTime.ToSubString()} --> {EndTime.ToSubString()}");

            foreach (var t in Text)
            {
                sb.AppendLine(t);
            }
            return sb.ToString();
        }
    }
}
