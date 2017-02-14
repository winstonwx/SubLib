using System;
using System.Collections.Generic;
using System.Text;

namespace SubLib.Facade
{
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
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
