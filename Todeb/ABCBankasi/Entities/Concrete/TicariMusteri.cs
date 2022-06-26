using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TicariMusteri : Musteri
    {
        public int MusteriId { get; set; }
        public string RuhsatNo { get; set; }
        public string TicariFaaliyet { get; set; }

    }
}
