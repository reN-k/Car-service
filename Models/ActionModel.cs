using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2.Models
{
    class ActionModel
    {
        public Action Action { get; set; }

        public string TextInfo { get; set; }

        public string Key { get; set; }
 
        public ActionModel(Action action, string text, string key = null)
        {
            Action = action;
            TextInfo = text;
            Key = key;
        }

        public void DisplayTextInfo()
        {
            Console.WriteLine($"{TextInfo}");
        }

    }
}
