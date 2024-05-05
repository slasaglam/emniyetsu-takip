using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace emniyet_suç_takip_proje
{
    internal class Program
    {
        static List<string> personeller = new List<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Tablo seciniz:");
                Console.WriteLine("(P)-Personel");
                Console.WriteLine("(A)-Adres");
                Console.WriteLine("(N)-Nakil");
                Console.WriteLine("(Ç)-çıkış");
                Console.WriteLine("İşlem yapılacak tablo seçiniz:");
                string tablo = Console.ReadLine().ToUpper();
                if (tablo == "P")
                {
                    if (File.Exists("Personel.SS") == false)
                    {
                        StreamWriter sw = new StreamWriter("Personel.SS", true, Encoding.Default);
                        sw.Close();

                    }
                    StreamReader sr = new StreamReader("Personel.SS", Encoding.Default);
                    string personel = "";
                    Console.WriteLine("dosyada kayıtlı personeller");
                    while ((personel = sr.ReadLine()) != null)
                    {
                        personeller.Add(personel);
                        string[] parca = personel.Split('#');
                        Console.WriteLine(parca[0] + "\t" + parca[1] + "\t" + parca[2] + "\t" + parca[3]);
                    }
                    sr.Close();
                    while (true)
                    {

                        Console.Clear();
                        Console.WriteLine("Personel Tablosu işlemleri:");
                        Console.WriteLine("1-Ekleme\r\n2-Silme\r\n3-Güncelleme\r\n4-Tümünü Silme\r\n5-Araya Ekle\r\n6-Bul\r\n7-Sırala\r\n8-Listeleme\r\n9-Ana Menüye Dön\r\n0-Çıkış\r\n");
                        Console.Write("Seciminiz:");
                        string secim = Console.ReadLine().ToUpper();

                        if (secim == "1")
                        {
                            string PersonelAd, Soyad, tcNo, telNo, gorev, rutbe, ozet, tekrarPersonel;
                            Console.WriteLine("Personel Ekleme İşlemleri");
                            do
                            {
                                while (true)
                                {
                                    Console.Write("Personel Adı:");
                                    PersonelAd = Console.ReadLine();
                                    if (PersonelAd.Length < 2 || PersonelAd.Length > 20)
                                    {
                                        Console.WriteLine("Ad uzunluğu en az 2 karakter en çok 20 karakter olmalıdır.");

                                    }
                                    else
                                        break;





                                }
                                while (true)
                                {
                                    Console.Write("Soyad:");
                                    Soyad = Console.ReadLine();
                                    if (Soyad.Length < 2 || Soyad.Length > 30)
                                    {
                                        Console.WriteLine("Soyad uzunluğu en az 2 karakter en çok 30 karakter olmalıdır.");

                                    }
                                    else
                                        break;

                                }
                                while (true)
                                {
                                    Console.Write("tcNo:");
                                    tcNo = Console.ReadLine();
                                    if (tcNo.Length != 11)
                                    {
                                        Console.WriteLine("tcNo uzunluğu 11 karakter olmalıdır.");

                                    }
                                    else
                                        break;

                                }
                                while (true)
                                {
                                    Console.Write("telNo:");
                                    telNo = Console.ReadLine();
                                    if (telNo.Length != 11)
                                    {
                                        Console.WriteLine("telNo uzunluğu 11 karakter olmalıdır.");

                                    }
                                    else
                                        break;

                                }
                                while (true)
                                {
                                    Console.Write("Gorev:");
                                    gorev = Console.ReadLine();
                                    if (gorev.Length < 2 || gorev.Length > 60)
                                    {
                                        Console.WriteLine("Gorev uzunluğu en az 2 en çok 60 karakter olmalıdır.");

                                    }
                                    else
                                        break;

                                }

                                while (true)
                                {
                                    Console.Write("rutbe:");
                                    rutbe = Console.ReadLine();
                                    if (rutbe.Length < 2 || rutbe.Length > 30)
                                    {
                                        Console.WriteLine("rutbe uzunluğu en az 2 en çok 30 karakter olmalıdır.");

                                    }
                                    else
                                        break;


                                }
                                while (true)
                                {
                                    Console.Write("ozet:");
                                    ozet = Console.ReadLine();
                                    if (ozet.Length < 20 || ozet.Length > 400)
                                    {
                                        Console.WriteLine("ozet uzunluğu en az 20 en çok 400 karakter olmalıdır.");

                                    }
                                    else
                                        break;

                                    string bilgi = PersonelAd + "#" + Soyad + "#" + tcNo + "#" + telNo + "#" + gorev + "#" + rutbe + "#";
                                    personeller.Add(bilgi);
                                    StreamWriter sw = new StreamWriter("Personel.SS", true, Encoding.Default);
                                    sw.WriteLine(bilgi);

                                    sw.Close();
                                    Console.WriteLine("Personel Eklendi. Tekrar Eklemek İstiyor Musunuz?");
                                    tekrarPersonel = Console.ReadLine().ToUpper();




                                } while (tekrarPersonel == "E")













                else if (tablo == "A")
                                        {

                                        }

                                        else if (tablo == "N")
                                        {


                                        }
                                        else if (tablo == "Ç")
                                        {
                                            Console.WriteLine("Çıkış Yapıldı Kapatmak için bir tuşa basınız");
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("hatalı seçim yaptını...");
                                        }
                            }
                            }
                    }


