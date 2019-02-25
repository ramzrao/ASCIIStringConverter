using ASCIIStringConverter.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASCIIStringConverter.Data.Repository
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        void InsertPerson(Person person);
    }
}
