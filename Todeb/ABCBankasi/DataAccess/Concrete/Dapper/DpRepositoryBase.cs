using Core.DataAccess;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Dapper
{
    public class DpRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        List<TEntity> dapperList = new List<TEntity>();
        public void Add(TEntity entity)
        {
            dapperList.Add(entity);
            Console.WriteLine("Dapper : Müşteri Eklendi");
        }

        public void Delete(TEntity entity)
        {
            dapperList.Remove(entity);
            Console.WriteLine("Dapper : Müşteri Silindi");
        }

        public List<TEntity> GetAll()
        {
            Console.WriteLine("Dapper : Müşteri Listelendi");
            return dapperList;

        }

        public void Update(TEntity entity)
        {
            Console.WriteLine("Dapper : Müşteri Güncellendi");
        }
    }
}
