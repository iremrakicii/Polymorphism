# Polymorphism Örneği - Geometrik Şekiller

Bu proje, C# dilinde polimorfizm (çok biçimlilik) konseptini kullanarak temel geometrik şekillerin alan hesaplamalarını içeren bir örnektir. Proje içerisinde **BaseGeometrikSekil** isimli bir temel sınıf ve bu sınıftan türetilen **Kare**, **Dikdörtgen** ve **Üçgen** isimli sınıflar bulunmaktadır. Her bir türetilen sınıf, `AlanHesapla` metodunu kendi geometrik şekli için uygun şekilde ezmektedir.

## Proje Yapısı

### Sınıflar

- **BaseGeometrikSekil**: Geometrik şekiller için temel bir sınıftır. Şekillerin genişlik ve yükseklik özelliklerini içerir. `AlanHesapla` metodu sanal (virtual) olarak tanımlanmıştır.
  
- **Kare**: Kare sınıfı, **BaseGeometrikSekil** sınıfından türetilmiştir ve `AlanHesapla` metodunu devralır.

- **Dıkdortgen**: Dikdörtgen sınıfı da **BaseGeometrikSekil** sınıfından türetilmiştir ve alanı hesaplamak için devraldığı metodu kullanır.

- **Ucgen**: Üçgen sınıfı da **BaseGeometrikSekil** sınıfından türetilmiştir. Ancak, üçgenin alanını hesaplamak için `AlanHesapla` metodunu ezerek `(taban * yükseklik) / 2` formülünü uygular.

### Polimorfizm Kullanımı

Polimorfizm sayesinde, **BaseGeometrikSekil** sınıfından türetilen her bir sınıf, kendi alan hesaplamasını yaparken aynı metodu kullanmaktadır. Örneğin, `BaseGeometrikSekil` türünden bir nesne `Kare`, `Dikdörtgen` ya da `Ucgen` sınıfı olarak davranabilir ve her bir şekil için doğru alan hesaplaması yapılır.

## Kullanılan Araç ve Teknolojiler
Programlama Dili: C# IDE: Visual Studio

## Kod Örneği

```csharp
BaseGeometrikSekil ucgen = new Ucgen(18, 20);
ucgen.AlanHesapla();

Console.WriteLine("------------------------------------------");

BaseGeometrikSekil kare = new Kare(14, 16);
kare.AlanHesapla();

Console.WriteLine("------------------------------------------");

BaseGeometrikSekil dıkdortgen = new Dıkdortgen(20, 30);
dıkdortgen.AlanHesapla();

## Örnek Çıktı:
Üçgenin alanı:180
------------------------------------------
Karenin alanı:224
------------------------------------------
Dikdörtgenin alanı:600



