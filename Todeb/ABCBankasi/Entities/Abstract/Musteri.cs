using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public abstract class Musteri:IEntity
    {
        public int Id { get; set; }//1 bireysel 2 kurumsal
        public string MusteriNo { get; set; }
    }
}
