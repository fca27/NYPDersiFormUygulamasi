using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Sinema
    {
        public int koltukSayisi;
        public string sinemaAdı;
        public int bakiye;
       
        public int BiletSat()
        {
            koltukSayisi = koltukSayisi -=1;
            return koltukSayisi;
            
        }

        public int BiletIptal()
        {
            koltukSayisi += 1;
            return koltukSayisi;
        }
        public int BosKoltukOgren()
        {
            return koltukSayisi;
        }
        public void BakiyeOgren()
        {
            
        }
    }
}
