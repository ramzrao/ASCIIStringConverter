using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ASCIIStringConverter.Data.Entities;

namespace ASCIIStringConverter.Data.Repository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(PersonDbContext dbContext) : base(dbContext) { }
        public async void InsertPerson(Person person)
        {
            await this.Create(person);
        }

    }
}
