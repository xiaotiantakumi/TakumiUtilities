using System;
using System.Collections.Generic;
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
    }
}
