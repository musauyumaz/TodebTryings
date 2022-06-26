using Core.Entities.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BireyselMusteri : Musteri,IEntity
    {
        public int MusteriId { get; set; }//1,6
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
    }
}
