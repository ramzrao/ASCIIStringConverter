using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIStringConverter.Business
{
    public interface IService<U>
    {
        Task<U> Handle(U obj);
    }
}
