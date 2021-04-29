using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulama
{
    class Fernandao : Futbolcu, ISutCekebilable
    {
        public string SutCek(float hiz, float mesafe)
        {
            return string.Format("{0} hiziyla {1} mesafeye kadar sut cekildi",hiz,mesafe);
        }
    }
}
