using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kişi kişi1 = new Kişi("hasan", "coşkun", "1");
            Kişi kişi2 = new Kişi("feyzan", "ege", "2");
            Kişi kişi3 = new Kişi("ismail hakkı", "coşkun", "3");
            Kişi kişi4 = new Kişi("kamile", "coşkun", "4");
            Kişi kişi5 = new Kişi("mert", "ege", "5");
            
            ArrayList kişi_listesi = new ArrayList();
            kişi_listesi.Add(kişi1);
            kişi_listesi.Add(kişi2);
            kişi_listesi.Add(kişi3);
            kişi_listesi.Add(kişi4);
            kişi_listesi.Add(kişi5);
            string tercih;
            Console.WriteLine("1-Numara Kaydet\n2-Numara Sil\n3-Numara Güncelle\n4-Rehber Listeleme\n5-Rehberde Arama\n6-Çıkmak için");
            
            while (true)
            {
                tercih = Console.ReadLine();
                if (tercih == "1")
                {
                    Console.WriteLine("isim giriniz");
                    string isim=Console.ReadLine();
                    Console.WriteLine("soyisim giriniz");
                    string soyisim = Console.ReadLine();
                    Console.WriteLine("numara giriniz");
                    string numara = Console.ReadLine();
                    Kişi kişinew=new Kişi(isim,soyisim,numara);
                    kişi_listesi.Add(kişinew);
                    continue;
                }
                else if (tercih == "2")
                {
                    Console.WriteLine("silmek istediğiniz numarayı yazınız:");
                    string no=Console.ReadLine();
                    Kişi silinecek_kişi=new Kişi("mehmet","coşkun","-1");
                    int silinecek_index=-1;
                    foreach(Kişi i in kişi_listesi)
                    {
                        if(i.no == no)
                        {
                            silinecek_kişi = i;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (silinecek_kişi.no != "-1")
                    {
                        kişi_listesi.Remove(silinecek_kişi);
                    }


                }
                else if (tercih == "3")
                {
                    string var_mı="0";
                    Console.WriteLine("güncellemek istediğiniz kişinin adını yazın:");
                    string isim =Console.ReadLine();
                    foreach (Kişi i in kişi_listesi)
                    {
                        if (i.ad == isim)
                        {
                            Console.WriteLine("Yeni Numarayı Yazınız:");
                            string no = Console.ReadLine();
                            i.no = no;
                            var_mı = "1";
                            continue;
                        }
                    }
                    if (var_mı != "1")
                    {
                        Console.WriteLine("Girdiğiniz kişi kayıtlı değil.");
                        continue;
                    }

                    
                }
                else if (tercih == "4")
                {
                    foreach(Kişi i in kişi_listesi)
                    {
                        Console.WriteLine("isim:{0} soyisim:{1} numara:{2}",i.ad,i.Soyad,i.no);
                    }
                    continue;

                }
                else if (tercih == "5")
                {
                    Console.WriteLine("Aramak istediğiniz kişinin adını veya soyismini giriniz: ");
                    string input=Console.ReadLine();
                    int counter = 0;
                    string new_no="yok";
                    foreach(Kişi i in kişi_listesi)
                    {
                        if(i.ad == input || i.soyad == input)
                        {
                            new_no = i.no;
                            counter++;
                        }
                    }
                    if(counter == 0)
                    {
                        Console.WriteLine("aradığınız numara yok");
                    }
                    else if(counter == 1)
                    {
                        Console.WriteLine("Aradığınız kişinin numarası:{0}", new_no);
                    }
                    else
                    {
                        Console.WriteLine("birden fazla kişi girdiğiniz isim veya soyisme sahip.");
                    }
                }
                else if (tercih == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("1-6 arasında sayı giriniz çıkmak için 6'ya basınız.");
                    continue;
                }
            }
            
            Console.ReadLine();
        }

    }
}
