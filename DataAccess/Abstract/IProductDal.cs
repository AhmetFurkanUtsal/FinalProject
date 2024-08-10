using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //NuGet
    //Product ile ilgili veritabanı işlemleri yapar
    public interface IProductDal: IEntityRepository<Product> // çalışma tipin prodct
    {



    }
}
