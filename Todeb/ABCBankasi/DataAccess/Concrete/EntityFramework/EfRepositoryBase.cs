using Core.DataAccess;
using Core.Entities.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity,new()
    {
        List<TEntity> entityFrameworkList;
        public EfRepositoryBase()
        {
           entityFrameworkList = new List<TEntity>();
        }
        public void Add(TEntity entity)
        {
            entityFrameworkList.Add(entity);
            Console.WriteLine("EntityFramework : Müşteri Eklendi");
        }

        public void Delete(TEntity entity)
        {
            entityFrameworkList.Remove(entity);
            Console.WriteLine("EntityFramework : Müşteri Silindi");
        }

        public List<TEntity> GetAll()
        {
            Console.WriteLine("EntityFramework : Müşteri Listelendi");
            return entityFrameworkList;
            
        }

        public void Update(TEntity entity)
        {
            Console.WriteLine("EntityFramework : Müşteri Güncellendi");
        }
    }
}
