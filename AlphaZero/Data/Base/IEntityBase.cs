using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaZero.Data.Base
{
    public interface IEntityBase
    {
        int ID { get; set; }
        Brand Brand { get; set; }
        double Price { get; set; }
        string ModelName { get; set; }
    }
}
