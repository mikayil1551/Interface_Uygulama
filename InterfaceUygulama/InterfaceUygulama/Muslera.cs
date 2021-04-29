using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulama
{
    class Muslera : Futbolcu, IToptutBilable1
    {
        public string TopTut()
        {
            return "Top tutuldu";
        }
    }
}
