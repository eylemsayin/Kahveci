using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabiaKandemir_EylemSayin_UygulamaSinavi
{
    public class Orders
    {
        public Boyut DrinkSize { get; set; }
        public int Count { get; set; }
        public int TotalTime { get; set; }
        public decimal TotalPrice { get; set; }
        public Icecekler ChoosenDrinks { get; set; }
        public List<ExtraMalzemeler> ExtraMaterials { get; set; }

        public void Hesapla()
        {
            TotalPrice = 0;
            TotalPrice += ChoosenDrinks.IcecekFiyati;
            if (DrinkSize == Boyut.Grande)
            {
                TotalPrice += TotalPrice * 0.25m;
            }
            else if (DrinkSize == Boyut.Venti)
            {
                TotalPrice += TotalPrice + 0.50m;
            }
            TotalPrice += ExtraMaterials.Sum(x => x.ExtraMalzemePrice);
            TotalPrice *= Count;
        }

        public override string ToString()
        {
            string ekstralar = "Ekstralar : " + Environment.NewLine;
            if (ExtraMaterials.Count == 0)
            {
                return $"İçecek Adı: {ChoosenDrinks.IcecekAdi}, Adedi : {Count}, Boyutu : {DrinkSize}, Toplam Tutar : {TotalPrice.ToString("c2")}";
            }
            foreach (var ekstra in ExtraMaterials)
            {
                ekstralar += ekstra.ExtraMaterialName + ",";
            }

            return $"İçecek Adı: {ChoosenDrinks.IcecekAdi}, Adedi: {Count}, Boyutu: {DrinkSize}, {ekstralar} ToplamTutar : {TotalPrice.ToString("c2")}";

        }
    }
}

