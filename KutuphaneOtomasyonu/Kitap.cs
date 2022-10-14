using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{
    internal class Kitap
    {
        public int UID;
        public string KitapAdi;
        public string Yazar;
        public string Tur;
        public string Yayinevi;
        public uint BasimYili;
        public Uye Sahip;
        public List<Uye> EskiSahipler;

        public void KitapKirala(Uye t_uye)
        {
            Sahip = t_uye;
        }

        public void KiralikSonlandir()
        {
            EskiSahipler.Add(Sahip);
            Sahip = null;
        }
    }

}
