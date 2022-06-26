using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KurumsalMusteriManager : IKurumsalMusteriService
    {
        private readonly IKurumsalMusteriDal _kurumsalMusteriDal;

        public KurumsalMusteriManager(IKurumsalMusteriDal kurumsalMusteriDal)
        {
            _kurumsalMusteriDal = kurumsalMusteriDal;
        }

        public void Add(KurumsalMusteri entity)
        {
            _kurumsalMusteriDal.Add(entity);
        }

        public void Delete(KurumsalMusteri entity)
        {
            _kurumsalMusteriDal.Delete(entity);
        }

        public List<KurumsalMusteri> GetAll()
        {
            return _kurumsalMusteriDal.GetAll();
        }

        public void Update(KurumsalMusteri entity)
        {
            _kurumsalMusteriDal.Update(entity);
        }
    }
}
