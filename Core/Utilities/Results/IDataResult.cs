using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // T(generic) tipinde değer döndürecek. ürün, kategori...
    // IResult'ta success ve message tanımlı olduğu için tekrardan yazmamak için implemente ettik.
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
