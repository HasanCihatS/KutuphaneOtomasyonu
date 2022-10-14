using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{
    internal class Raf
    {
        public string Tur { get; set; }
        public List<Kitap> KitapList;
        
        public void KitapEkle(Kitap t_kitap)
        {
            KitapList.Add(t_kitap);
        }

        public void KitapCikar(Kitap t_kitap)
        {
            KitapList.Remove(t_kitap);
        }
    }
}
