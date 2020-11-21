using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TakumiUtilities
{
    public class StringUtility
    {
        public String ValidateTarget { get;}
        public StringUtility(string validateTarget)
        {
            ValidateTarget = validateTarget;
        }

        public bool StartWith(string target)
        {
            return ValidateTarget.StartsWith(target);
        }

        public string[] SplitEx(int splitPosition, string splitStr)
        {
            // splitPositionで区切るといくつの部分に分割できるか
            int cntPart = (ValidateTarget.Length + splitPosition - 1) / splitPosition;
            List<string> result = new List<string>();
            for (int i = 0; i < cntPart; i++)
            {
                var partStr = new string(ValidateTarget.Skip(i * splitPosition).Take(splitPosition).ToArray());
                result.AddRange(partStr.Split(splitStr));
            }

            return result.ToArray();
        }
    }
}
