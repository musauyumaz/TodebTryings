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
    public class BireyselMusteriManager:IBireyselMusteriService
    {
        private readonly IBireyselMusteriDal _bireyselMusteriDal;

        public BireyselMusteriManager(IBireyselMusteriDal bireyselMusteriDal)
        {
            _bireyselMusteriDal = bireyselMusteriDal;
        }

        public void Add(BireyselMusteri entity)
        {
            _bireyselMusteriDal.Add(entity);
        }

        public void Delete(BireyselMusteri entity)
        {
            _bireyselMusteriDal.Delete(entity);
        }

        public List<BireyselMusteri> GetAll()
        {
            return _bireyselMusteriDal.GetAll();
        }

        public void Update(BireyselMusteri entity)
        {
            _bireyselMusteriDal.Update(entity);
        }
    }
}
