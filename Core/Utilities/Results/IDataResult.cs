using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // mesaj + işlem sonucu + data yı içerecek
    // I Result ta mesaj ve işlem sonucu var
    public interface IDataResult<T> : IResult
        // T------ List<Product>, <Category> vb.
    {
        T Data { get; }
    }
}
