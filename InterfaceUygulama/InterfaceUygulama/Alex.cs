using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulama
{
    class Alex : Futbolcu,ISutCekebilable ,IOyunKurabilable
    {
       
        public string CalimAt(float hiz)
        {
            return string.Format("{0}-hizla calim atildi",hiz);
        }

        public string OyunKur()
        {
            return "Oyun kuruldu";
        }

        public string SutCek(float hiz, float mesafe)
        {
            return string.Format("{0} hiziyla {1} mesafeye kadar atildi", hiz, mesafe);
        }
    }
}
