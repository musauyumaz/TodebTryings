using Core.Entities.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class KurumsalMusteri:Musteri,IEntity
    {
        public int MusteriId { get; set; }//2,3,4,5
        public string Unvan { get; set; }
        public string OrganizasyonAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
