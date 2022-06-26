using Business.Concrete;
using DataAccess.Concrete.Dapper;
using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        //DRY - Do Not Repeat Yourself
        static void Main(string[] args)
        {
            
            BireyselMusteri musa = new BireyselMusteri() { Id=1,MusteriNo="12345",Ad="Musa",Soyad="Uyumaz",TcNo="12345678910"};
            KurumsalMusteri turkcell = new KurumsalMusteri() { Id = 2, MusteriNo = "12346",Unvan="Telekominasyon",OrganizasyonAdi="Turkcell",VergiNo="12345678911" };
            TicariMusteri bakkal = new TicariMusteri() { Id=2,MusteriNo="12347",RuhsatNo = "12345678912",TicariFaaliyet="Market"};
            BireyselMusteriManager bireyselMusteriManager = new BireyselMusteriManager(new EfBireyselMusteriDal());
            KurumsalMusteriManager kurumsalMusteriManager = new KurumsalMusteriManager(new EfKurumsalMusteriDal());
            TicariMusteriManager ticariMusteriManager = new TicariMusteriManager(new DpTicariMusteriDal());

            bireyselMusteriManager.Add(musa);
            kurumsalMusteriManager.Add(turkcell);
            ticariMusteriManager.Add(bakkal);

            foreach (var item in bireyselMusteriManager.GetAll())
            {
                Console.WriteLine(item.Id+" "+item.MusteriNo+" "+item.Ad+" "+item.Soyad+" "+item.TcNo);
            }

            foreach (var item in kurumsalMusteriManager.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.MusteriNo + " " + item.Unvan + " " + item.OrganizasyonAdi + " " + item.VergiNo);
            }
            foreach (var item in ticariMusteriManager.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.MusteriNo + " " + item.TicariFaaliyet + " " + item.RuhsatNo);
            }
            bireyselMusteriManager.Update(musa);
            kurumsalMusteriManager.Update(turkcell);
            ticariMusteriManager.Update(bakkal);

            bireyselMusteriManager.Delete(musa);
            kurumsalMusteriManager.Delete(turkcell);
            ticariMusteriManager.Delete(bakkal);

            foreach (var item in bireyselMusteriManager.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.MusteriNo + " " + item.Ad + " " + item.Soyad + " " + item.TcNo);
            }

            foreach (var item in kurumsalMusteriManager.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.MusteriNo + " " + item.Unvan + " " + item.OrganizasyonAdi + " " + item.VergiNo);
            }
            foreach (var item in ticariMusteriManager.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.MusteriNo + " " + item.TicariFaaliyet + " " + item.RuhsatNo);
            }
        }
    }
}
