using SL_Cars_v2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2.Menues
{
    interface IMenuable
    {        
        public string MenuName { get; }
        public string ChooseString { get; }

        public ActionDictionaryModel ActionDictionary { get; }
                
        public void DisplayMenu() { }
    }
}
