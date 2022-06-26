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
    public class TicariMusteriManager : ITicariMusteriService
    {
        private ITicariMusteriDal _ticariMusteriDal;

        public TicariMusteriManager(ITicariMusteriDal ticariMusteriDal)
        {
            _ticariMusteriDal = ticariMusteriDal;
        }

        public void Add(TicariMusteri entity)
        {
            _ticariMusteriDal.Add(entity);
        }

        public void Delete(TicariMusteri entity)
        {
            _ticariMusteriDal.Delete(entity);
        }

        public List<TicariMusteri> GetAll()
        {
            return _ticariMusteriDal.GetAll();
        }

        public void Update(TicariMusteri entity)
        {
            _ticariMusteriDal.Update(entity);
        }
    }
}
