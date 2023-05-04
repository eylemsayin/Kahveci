namespace RabiaKandemir_EylemSayin_UygulamaSinavi
{
    public class Icecekler
    {
        public string IcecekAdi { get; set; }
        public decimal IcecekFiyati { get; set; }
        public int HazirlanmaSuresi { get; set; }
        public override string ToString()
        {
            return IcecekAdi;
        }
    }
}