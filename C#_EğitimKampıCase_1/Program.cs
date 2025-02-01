using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EğitimKampıCase_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Video_1 Uygulamaları

            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");

            //***************************************

            string customerName;
            string customerSurname;
            string customerEmail;
            string customerPhone;
            string city, district;

            customerName = "Şahin";
            customerSurname = "Kaya";
            customerEmail = "deneme@gmail.com";
            customerPhone = "+90 500 400 20 23";
            city = "Kadıköy";
            district = "İstanbul";

            Console.WriteLine();
            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone + "\n" + "Email: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("----------------------");

            //***************************************

            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerEmail = "test@gmail.com";
            customerPhone = "+90 500 102 24 58";
            district = "Sapanca";
            city = "Sakarya";

            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone + "\n" + "Email: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("----------------------");

            //***************************************

            int hamburgerFiyatı = 300;
            int kolaFiyatı = 35;
            int patatesKızartmazıFiyatı = 50;
            int pizzaFiyatı = 200;
            int limonataFiyatı = 35;
            int suFiyatı = 5;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerFiyatı + " TL" + "\n" + "Kola: " + kolaFiyatı + " TL");
            Console.WriteLine("Patates Kızartması: " + patatesKızartmazıFiyatı + " TL" + "\n" + "su: " + suFiyatı + " TL");
            Console.WriteLine("Pizza: " + pizzaFiyatı + " TL" + "\n" + "Limonata: " + limonataFiyatı + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");

            Console.WriteLine();
            Console.WriteLine("***** Hesap *****");
            Console.WriteLine();
            int toplamFiyat = 0;

            int hamburgerCount = 3;
            int colaCount = 3;
            int friesCount = 1;
            int pizzaCount = 2;
            int waterCount = 3;
            int lemonadeCount = 0;

            int hamburgerToplamFiyat = hamburgerCount * hamburgerFiyatı;
            int kolaToplamFiyat = colaCount * kolaFiyatı;
            int limonataToplamFiyat = lemonadeCount * limonataFiyatı;
            int suToplamFiyat = waterCount * suFiyatı;
            int pizzaToplamFiyat = pizzaCount * pizzaFiyatı;
            int patatesKızartmasıToplamFiyat = friesCount * patatesKızartmazıFiyatı;

            Console.WriteLine("Hamburger Tutarı: " + hamburgerToplamFiyat + " TL" + "\n" + "Kola Tutarı: " + kolaToplamFiyat + " TL");
            Console.WriteLine("Limonata Tutarı: " + limonataToplamFiyat + " TL" + "\n" + "Su Tutarı: " + suToplamFiyat + " TL");
            Console.WriteLine("Patates Kızartması Tutarı: " + patatesKızartmasıToplamFiyat + " TL" + "\n" + "Pizza Tutarı: " + pizzaToplamFiyat + " TL");
            Console.WriteLine();
            toplamFiyat = hamburgerToplamFiyat + kolaToplamFiyat + patatesKızartmasıToplamFiyat + pizzaToplamFiyat + limonataToplamFiyat + suToplamFiyat;
            Console.WriteLine("Toplam Hesap: " + toplamFiyat);

            //***************************************

            //Video_2 Uygulamaları

            Console.WriteLine();
            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();

            double elma_kg_Fiyat, patates_kg_Fiyat, çilek_kg_Fiyat, portakal_kg_Fiyat, domates_kg_Fiyat;

            elma_kg_Fiyat = 14.85;
            portakal_kg_Fiyat = 20.35;
            çilek_kg_Fiyat = 35.15;
            domates_kg_Fiyat = 15.50;
            patates_kg_Fiyat = 17.85;

            Console.WriteLine("----Elma Fiyatı: " + elma_kg_Fiyat + " TL");
            Console.WriteLine("----Portakal Fiyatı: " + portakal_kg_Fiyat + " TL");
            Console.WriteLine("----Çilek Fiyatı: " + çilek_kg_Fiyat + " TL");
            Console.WriteLine("----Patates Fiyatı: " + patates_kg_Fiyat + " TL");
            Console.WriteLine("----Domates Fiyatı: " + domates_kg_Fiyat + " TL");
            Console.WriteLine();

            double elmaGram, domatesGram, portakalGram, çilekGram, patatesGram;
            elmaGram = 1.245; domatesGram = 2.568; portakalGram = 1.485; çilekGram = 2.584; patatesGram = 1.236;

            double elma_toplamFiyat = elmaGram * elma_kg_Fiyat;
            double portakal_toplamFiyat = portakalGram * portakal_kg_Fiyat;
            double çilek_toplamFiyat = çilekGram * çilek_kg_Fiyat;
            double domates_toplamFiyat = domatesGram * domates_kg_Fiyat;
            double patates_toplamFiyat = patatesGram * patates_kg_Fiyat;

            Console.WriteLine("Alınan Ürün: -Elma" + "Birim Fiyatı: " + elma_kg_Fiyat + "Alınan gram: " + elmaGram + "Toplam Fiyatı: " + elma_toplamFiyat);
            Console.WriteLine("Alınan Ürün: -Portakal" + "Birim Fiyatı: " + portakal_kg_Fiyat + "Alınan gram: " + portakalGram + "Toplam Fiyatı: " + portakal_toplamFiyat);
            Console.WriteLine("Alınan Ürün: -Çilek" + "Birim Fiyatı: " + çilek_kg_Fiyat + "Alınan gram: " + çilekGram + "Toplam Fiyatı: " + çilek_toplamFiyat);
            Console.WriteLine("Alınan Ürün: -Domates" + "Birim Fiyatı: " + domates_kg_Fiyat + "Alınan gram: " + domatesGram + "Toplam Fiyatı: " + domates_toplamFiyat);
            Console.WriteLine("Alınan Ürün: -Patates" + "Birim Fiyatı: " + patates_kg_Fiyat + "Alınan gram: " + patatesGram + "Toplam Fiyatı: " + patates_toplamFiyat);
            Console.WriteLine();
            Console.WriteLine("Toplam Ödenecek Tutar: " + (elma_toplamFiyat + portakal_toplamFiyat + çilek_toplamFiyat + patates_toplamFiyat + domates_toplamFiyat) + " TL");

            //***************************************

            Console.WriteLine();
            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);
            Console.WriteLine();

            //***************************************

            Console.WriteLine("Csharp Havayolu Yolcu Bilgisi");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerIdentityNumber, passengerAge;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();
            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();
            Console.Write("Yolcunun yaşadığı ilçe: ");
            passengerDistrict = Console.ReadLine();
            Console.Write("Yolcunun yaşadığı şehir: ");
            passengerCity = Console.ReadLine();
            Console.Write("Yolcu Yaşı: ");
            passengerAge = Console.ReadLine();
            Console.Write("Yolcunun TC kimlik numarası: ");
            passengerIdentityNumber = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("---------- Yolcu Bilgi Kartı ----------");
            Console.WriteLine();
            Console.WriteLine("Yolcu Adı ve Soyadı: " + passengerName + " " + passengerSurname);
            Console.WriteLine("Yolcunun yaşadığı yer bilgisi: " + "\n" + "-İlçe ve İl: " + passengerDistrict + "/" + passengerCity);
            Console.WriteLine("Yolcunun yaşı: " + passengerAge);
            Console.WriteLine("Yolcunun TC kimlik numarası: " + passengerIdentityNumber);
            Console.WriteLine();

            //***************************************

            int shoePrice, computerPrice, chairPrice, tvPrice;
            shoePrice = 1000;
            chairPrice = 750;
            tvPrice = 15000;
            computerPrice = 50000;

            int shoeCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoeCount = int.Parse(Console.ReadLine()); 

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            Console.Write("\n" + "Toplam ücret: " + totalPrice);
            Console.WriteLine();

            //***************************************

            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1. sınav notunu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. sınav notunu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3. sınav notunu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.Write("Not ortalamanız: " + result);
            Console.WriteLine();

            //***************************************

            char gender;
            Console.Write("Lütfen cinsiyetinizi giriniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Cinsiyetiniz: " + gender);

            //***************************************

            Console.Read();
        }
    }
}
