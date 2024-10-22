namespace Polymorphism
{
    public class BaseGeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public BaseGeometrikSekil(double _genislik, double _yukseklik)
        {
            Genislik = _genislik;
            Yukseklik = _yukseklik;
        }

        public virtual double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }
    public class Kare : BaseGeometrikSekil
    {
        public Kare(double _genislik, double _yukseklik) : base(_genislik, _yukseklik)
        {
            Genislik = _genislik;
            Yukseklik = _yukseklik;
            Console.WriteLine($"Karenin alanı:{AlanHesapla()}");
        }

        public override double AlanHesapla()
        {
            return base.AlanHesapla();
        }
    }

    public class Dıkdortgen : BaseGeometrikSekil
    {
        public Dıkdortgen(double _genislik, double _yukseklik) : base(_genislik, _yukseklik)
        {
            Genislik = _genislik;
            Yukseklik = _yukseklik;
            Console.WriteLine($"Dikdörtgenin alanı:{AlanHesapla()}");
        }
        public override double AlanHesapla()
        {
            return base.AlanHesapla();
        }
    }

    public class Ucgen : BaseGeometrikSekil
    {
        public Ucgen(double taban, double yukseklik) : base(taban, yukseklik)
        {
            Genislik = taban;
            Yukseklik = yukseklik;

            Console.WriteLine($"Üçgenin alanı:{AlanHesapla()}");

        }
        public override double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2;

        }
    }

}
