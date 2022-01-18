using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dip.Model
{
    class MongoDbProduct: DbProduct
    {
        public string GetProductById(string id)
        {
            return $"MongoDB: Exibindo dados do produto {id}.";
        }
    }
}
