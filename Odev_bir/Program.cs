using System;

namespace Odev_bir
{
    class Program
    {
        static  void Main(string[] args)
        {
            /*Soru 1:Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/

            Console.WriteLine("Bir pozitif tam sayı giriniz: ");
            int sayi=int.Parse(Console.ReadLine());
            int[] sayilar=new int[sayi];
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("{0}.sayıyı giriniz: ",i+1);
                sayilar[i]=int.Parse(Console.ReadLine());
            }
            foreach (var item in sayilar)
            {
                if(item%2==0)
                {
                    Console.WriteLine(item);
                }
            }
             
            /*Soru 2:Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/
            Console.WriteLine("İki Tane Sayi Giriniz: ");
            int sayi1=int.Parse(Console.ReadLine());
            int sayi2=int.Parse(Console.ReadLine());
            int[] stop=new int[sayi1];
            Console.WriteLine("{0} Adet Pozitif Tam Sayı Giriniz:",sayi1);
            for (int i = 0; i < sayi1; i++)
            {
                Console.WriteLine("{0}.Sayıyı Giriniz.",i+1);
                stop[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Girilen Sayılardan Sayi2'ye Eşit ve Tam Bölünen Sayılar");
            foreach (var item in stop)
            {
                if(item==sayi2 || item%sayi2==0)
                {
                    Console.WriteLine(item);
                }
            }
            /*Soru 3:Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/
            Console.WriteLine("Pozitif Bir Tam Sayı Giriniz:");
            int s1=int.Parse(Console.ReadLine());
            Console.WriteLine("{0} Adet Kelime Girişi Yapınız: ",s1);
            string[] kelime=new string[s1];
            for (int i = 0; i < kelime.Length; i++)
            {
                Console.WriteLine("{0}.Kelime:",i+1);
                kelime[i]=Console.ReadLine();
            }

            Array.Reverse(kelime);
            Console.WriteLine("Kelimlerin Sondan Başa Doğru Sıralanmış Hali");
            foreach (string item in kelime)
            {
                Console.WriteLine(item);
            }
            
            /*Soru 4:Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/
            Console.WriteLine("Bir cümle Yazınız");
            string cumle=Console.ReadLine();
            Console.WriteLine("Cümledeki Harf Sayısı:{0}",cumle.Length);
            string[] kelimeler=cumle.Split(' ');
            Console.WriteLine("Kelime Sayısı:{0}",kelimeler.Length);


        }
    }
}
