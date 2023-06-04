using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyunu
{
    internal class Program
    {
        public static void SeçimOyuncu(int SeçimOyuncu)
        {
            int[] Karakterler = { 1, 2, 3, 4 };
            int[] SavaşGücü = { 50, 20, 70, 60 };
            int[] Can = { 500, 700, 350, 400 };
            int[] ıskalamaDeger = { 10, 15, 9, 7 };





            if (SeçimOyuncu == Karakterler[0])
            {
                Console.WriteLine("Seçtiğiniz Karakter  = Savaşçı");
                Console.WriteLine("Savaş Gücü : " + SavaşGücü[0]);
                Console.WriteLine("Canı : " + Can[0]);
                Console.WriteLine("ıskalama ihtimalı  yüzde : " + ıskalamaDeger[0]);



            }
            else if (SeçimOyuncu == Karakterler[1])
            {
                Console.WriteLine("Seçtiğiniz Karakter  = Tank");
                Console.WriteLine("Savaş Gücü : " + SavaşGücü[1]);
                Console.WriteLine("Canı : " + Can[1]);
                Console.WriteLine("ıskalama ihtimalı  yüzde : " + ıskalamaDeger[1]);
            }
            else if (SeçimOyuncu == Karakterler[2])
            {
                Console.WriteLine("Seçtiğiniz Karakter  = Büyücü");
                Console.WriteLine("Savaş Gücü : " + SavaşGücü[2]);
                Console.WriteLine("Canı : " + Can[2]);
                Console.WriteLine("ıskalama ihtimalı  yüzde : " + ıskalamaDeger[2]);
            }
            else if (SeçimOyuncu == Karakterler[3])
            {
                Console.WriteLine("Seçtiğiniz Karakter  = Suikastçi");
                Console.WriteLine("Savaş Gücü : " + SavaşGücü[3]);
                Console.WriteLine("Canı : " + Can[3]);
                Console.WriteLine("ıskalama ihtimalı  yüzde : " + ıskalamaDeger[3]);
            }
            else
            {
                Console.WriteLine("Yanlış sayı seçtiniz Lütfen 1 ile 4 arasında karakter seçimi yapınız");





            }

        }


        public static void SeçimDüşman(int SeçimDüşman)
        {
            int[] Karakterler = { 1, 2, 3, 4 };
            int[] SavaşGücü = { 50, 20, 70, 60 };
            int[] Can = { 500, 700, 350, 400 };
            int[] ıskalamaDeger = { 10, 15, 9, 7 };

            if (SeçimDüşman == Karakterler[0])
            {
                Console.WriteLine("Düşmanınızın Seçtiği Karakter  = Savaşçı");
                Console.WriteLine("Savaş Gücü : " + SavaşGücü[0]);
                Console.WriteLine("Canı : " + Can[0]);
                Console.WriteLine("ıskalama ihtimalı  yüzde : " + ıskalamaDeger[0]);



            }
            else if (SeçimDüşman == Karakterler[1])
            {
                Console.WriteLine("Düşmanınızın Seçtiği Karakter  = Tank");
                Console.WriteLine("Savaş Gücü : " + SavaşGücü[1]);
                Console.WriteLine("Canı : " + Can[1]);
                Console.WriteLine("ıskalama ihtimalı  yüzde : " + ıskalamaDeger[1]);
            }
            else if (SeçimDüşman == Karakterler[2])
            {
                Console.WriteLine("Düşmanınızın Seçtiği Karakter  = Büyücü");
                Console.WriteLine("Savaş Gücü : " + SavaşGücü[2]);
                Console.WriteLine("Canı : " + Can[2]);
                Console.WriteLine("ıskalama ihtimalı  yüzde : " + ıskalamaDeger[2]);
            }
            else if (SeçimDüşman == Karakterler[3])
            {
                Console.WriteLine("Düşmanınızın Seçtiği Karakter  = Suikastçi");
                Console.WriteLine("Savaş Gücü : " + SavaşGücü[3]);
                Console.WriteLine("Canı : " + Can[3]);
                Console.WriteLine("ıskalama ihtimalı  yüzde : " + ıskalamaDeger[3]);
            }

        }

        
        public static void OyunBaşlat()
        {
        

            Random random = new Random();
            Random rdIskalama = new Random();
            int[] Karakterler = { 1, 2, 3, 4 };
            int[] SavaşGücü = { 50, 20, 70, 60 };
            int[] Can = { 500, 700, 350, 400 };
            int[] ıskalamaDeger = { 10, 15, 9, 7 };
            Oyun:
            while (true)
            {

                Console.WriteLine("Savaş Oyununa Hoşgeldiniz ");
                Console.WriteLine("********************************************************");

                string karakterMenü = "1 -Savaşçı\n2 - Tank\n3 - Büyücü\n4 - Suikastçi";
                Console.WriteLine(karakterMenü);
                Console.WriteLine();
                Console.Write("İstediğiniz karakterin numarasını girin = ");

                int OyuncukarakterSeçim = int.Parse(Console.ReadLine());
                int BilgisayarKarakterSeçim = random.Next(1, 4);
                Console.WriteLine();
                SeçimOyuncu(OyuncukarakterSeçim);
                Console.WriteLine();
                Console.WriteLine("*********************************************");
                Console.WriteLine("*********************************************");
                Console.WriteLine();
                SeçimDüşman(BilgisayarKarakterSeçim);

                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine("************************************");

                    evetHayır:
                    Console.Write("Savaş Başlasın mı ? E - H =");
                    String istek = Console.ReadLine().ToUpper();  
                   if(istek == "E")
                   {
                    Console.WriteLine("Savaş Başlıyor.........");
                   }
                   else if (istek =="H")
                   {
                    goto finis;
                   }
                   else
                   {
                    Console.WriteLine("Yanlış Tuşa Bastınız !!!");
                    goto evetHayır;
                   }

                   

                
                

                

                while (true)
                {
                    int ıskalamaSayı = rdIskalama.Next(1, 100);
                    int ıskalamaSayı2 = rdIskalama.Next(1, 100);
                    Console.WriteLine("Saldırmak için ENTER tuşuna basın");
                    Console.ReadLine();
                    if (ıskalamaSayı <= ıskalamaDeger[OyuncukarakterSeçim - 1])
                    {
                        Console.WriteLine("Iskaladınız...");
                        Console.WriteLine("Sıra Rakipte");


                        Console.WriteLine();
                        Console.WriteLine("****************************************************");
                        Console.WriteLine("Rakibin saldırısını görmek için Enter tuşuna basın");
                        Console.ReadLine();

                        if (ıskalamaSayı2 <= ıskalamaDeger[BilgisayarKarakterSeçim - 1])
                        {
                            Console.WriteLine("Düşman Iskaladıı   :))))!!!");

                        }
                        else
                        {
                            Console.WriteLine("Düşman  Fena Vurdu!!!");
                            Can[OyuncukarakterSeçim - 1] = Can[OyuncukarakterSeçim - 1] - SavaşGücü[BilgisayarKarakterSeçim - 1];
                            if (Can[OyuncukarakterSeçim - 1] <= 0)
                            {  
                                Console.WriteLine("Oyunu Kaybettiniz...:(((");
                                Console.WriteLine("Tekrar Oynamak İstermisiniz ? E\t H\t");
                                while (true)
                                {
                                    String OyunTekrar1 = Console.ReadLine().ToUpper();
                                    if (OyunTekrar1 == "E")
                                    {

                                        goto Oyun;
                                    }
                                    else if (OyunTekrar1 == "H")
                                    {
                                        Console.WriteLine("Oyundan Çıkılıyor...");

                                        goto finis;

                                    }
                                    else
                                    {
                                        Console.WriteLine("Yanlış tuşa bastınız lütfen doğru seçim yapınız");
                                        
                                    }



                                }
                            }
                            else
                            {
                                Console.WriteLine("Kalan Canımız !!!  = " + Can[OyuncukarakterSeçim - 1]);

                            }





                        }




                    }

                    else
                    {
                        Console.WriteLine("Vuruşunuz Başarılı");
                        Can[BilgisayarKarakterSeçim - 1] = Can[BilgisayarKarakterSeçim - 1] - SavaşGücü[OyuncukarakterSeçim - 1];
                        if (Can[BilgisayarKarakterSeçim - 1] <= 0)
                        {
                            Console.WriteLine("Tebrikler Oyunu Kazandınız... :)))");
                            Console.WriteLine("Tekrar Oynamak İstermisiniz ? E\t H\t");


                            while (true)
                            {
                                String OyunTekrar2 = Console.ReadLine().ToUpper();
                                if (OyunTekrar2 == "E")
                                {

                                    goto Oyun;
                                }
                                else if (OyunTekrar2 == "H")
                                {
                                    Console.WriteLine("Oyundan Çıkılıyor...");

                                    goto finis;

                                }
                                else
                                {
                                    Console.WriteLine("Yanlış tuşa bastınız lütfen doğru seçim yapınız");
                                }

                            }

                        }

                        Console.WriteLine("Düşmanınızın Kalan Canı = " + Can[BilgisayarKarakterSeçim - 1]);
                        Console.WriteLine();
                        Console.WriteLine("****************************************************");
                        Console.WriteLine("Rakibin saldırısını görmek için Enter tuşuna basın");
                        Console.ReadLine();

                        if (ıskalamaSayı2 <= ıskalamaDeger[BilgisayarKarakterSeçim - 1])
                        {
                            Console.WriteLine("Düşman Iskaladıı   :))))!!!");

                        }
                        else
                        {
                            Console.WriteLine("Düşman  Fena Vurdu!!!");
                            Can[OyuncukarakterSeçim - 1] = Can[OyuncukarakterSeçim - 1] - SavaşGücü[BilgisayarKarakterSeçim - 1];
                            if (Can[OyuncukarakterSeçim - 1] <= 0)
                            {
                                Console.WriteLine("Oyunu Kaybettiniz...:(((");
                                Console.WriteLine("Tekrar Oynamak İstermisiniz ? E\t H\t");


                                while (true)
                                {
                                    String OyunTekrar3 = Console.ReadLine().ToUpper();
                                    if (OyunTekrar3 == "E")
                                    {

                                        goto Oyun;
                                    }
                                    else if (OyunTekrar3 == "H")
                                    {
                                        Console.WriteLine("Oyundan Çıkılıyor...");

                                        goto finis;

                                    }
                                    else
                                    {
                                        Console.WriteLine("Yanlış tuşa bastınız lütfen doğru seçim yapınız");
                                    }

                                }

                            }
                            else
                            {
                                Console.WriteLine("Kalan Canımız !!!  = " + Can[OyuncukarakterSeçim - 1]);

                            }





                        }

                    }

                }







                finis:
                Console.WriteLine("Oyundan Çıkılıyor....");
                break;

            }






        }
        
        
        
        public static void Main(string[] args) {

            OyunBaşlat();
        
        
        
        
      }

    }
}