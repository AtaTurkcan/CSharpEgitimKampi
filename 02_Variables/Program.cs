using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);
            #endregion

            #region Manav Fiyatlandırması
            //            Console.WriteLine("***** Fiyat Listesi *****");
            //            Console.WriteLine();

            //            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //            applePrice = 14.85;
            //            orangePrice = 20.95;
            //            strawberryPrice = 45;
            //            potatoPrice = 9.74;
            //            tomatoPrice = 6.88;

            //            Console.WriteLine("---- Elma Birim Fiyatı : " + applePrice);
            //            Console.WriteLine("---- Portakal Birim Fiyatı : " + orangePrice);
            //            Console.WriteLine("---- Çilek Birim Fiyatı : " + strawberryPrice);
            //            Console.WriteLine("---- Patates Birim Fiyatı : " + potatoPrice);
            //            Console.WriteLine("---- Domates Birim Fiyatı : " + tomatoPrice);
            //            Console.WriteLine();

            //            double appleGram, orangeGram, strawberryGram,potatoGram, tomatoGram;
            //            appleGram = 1.245;
            //            orangeGram = 2.65;
            //            strawberryGram = 0.75;
            //            potatoGram = 4.859;
            //            tomatoGram = 3.745;

            //            double appleCost, orangeCost, strawberryCost, potatoCost, tomatoCost;
            //            appleCost = applePrice * appleGram;
            //            orangeCost = orangePrice * orangeGram;
            //            strawberryCost = strawberryPrice * strawberryGram;
            //            potatoCost = potatoPrice * potatoGram;
            //            tomatoCost = tomatoPrice * tomatoGram;

            //            double totalCost = appleCost + orangeCost + strawberryCost + potatoCost + tomatoCost;

            //            Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleCost + " TL"); 
            //            Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeCost + " TL"); 
            //            Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryCost + " TL"); 
            //            Console.WriteLine("Alınan Ürün: Patates - Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoCost + " TL"); 
            //            Console.WriteLine("Alınan Ürün: Domates - Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoCost + " TL");
            //            Console.WriteLine();
            //            Console.WriteLine("Alışveriş Toplam Tutar: "+totalCost+ " TL");
            #endregion

            #region Char veriTipi Konsoldan Alma
            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerID;

            //Console.Write("Yolcu Adı: ");
            //passengerName=Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname=Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict=Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity=Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passengerAge=Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerID=Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " +passengerID + " - Yolcu Ad Soyad: "+passengerName+" "+passengerSurname+ " "+passengerDistrict+"/"+passengerCity+" "+passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşüm
            // İpucu : Konsoldan alınan ifadeyi int ve double dönüştürmek için .Parse() metodu kullanılır.

            //int shoesPrice, compPrice, chairPrice, tvPrice;
            //shoesPrice = 250;
            //compPrice = 35000;
            //chairPrice = 1000;
            //tvPrice = 25000;

            //int shoesCount, compCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı miktarını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar miktarını giriniz: ");
            //compCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye miktarını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon miktarını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + compCount * compPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Ödemeniz Gereken Tutar: "+totalPrice);
            #endregion

            #region Klavyeden Ondalıklı Sayı Girişi

            //double exam1, exam2, exam3,result;
            //Console.Write("Lütfen birinci sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen üçüncü sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Ortalamanız: " + result);
            //#endregion

            //#region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
