using ASCIIStringConverter.Common;
using ASCIIStringConverter.Common.Models;
using ASCIIStringConverter.Common.Extensions;
using ASCIIStringConverter.Data.Entities;
using ASCIIStringConverter.Data.Repository;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace ASCIIStringConverter.Business
{
    public class PersonService : IService<PersonVM>
    {
        private IPersonRepository personRepository;
        private IMapper mapper;
        public PersonService(IPersonRepository personRepository,IMapper mapper)
        {
            this.personRepository = personRepository;
            this.mapper = mapper;
        }
        public async Task<PersonVM> Handle(PersonVM personVM)
        {
            try
            {
                await personRepository.Create(mapper.Map<Person>(personVM));
                String binaryStr = BinaryConverter.ConvertToBinary(StringToASCIIConverter.ASCIICharSum((personVM as PersonVM).FullName));
                personVM.ZeroCntInBinASCIIName = binaryStr.CountConsecutiveCharacters('0');
                return personVM;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
