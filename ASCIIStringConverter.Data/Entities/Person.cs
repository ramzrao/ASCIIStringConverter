using System;
using System.Collections.Generic;
using System.Text;

namespace ASCIIStringConverter.Data.Entities
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
