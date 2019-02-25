using ASCIIStringConverter.Common.Models;
using ASCIIStringConverter.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASCIIStringConverter.API.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonVM, Person>().ConvertUsing(new SpaceDelimitedStringConverter());
                       }
    }
    public class SpaceDelimitedStringConverter : ITypeConverter<PersonVM, Person>
    {
        public Person Convert(PersonVM src,Person dest,ResolutionContext context)
        {
            string[] tokens = src.FullName.Split(' ');

            Person result = new Person();

            if(tokens.Length == 1)
            {
                result.FirstName = tokens[0];
                result.LastName = string.Empty;
            }
            else if (tokens.Length == 2)
            {
               
                result.FirstName = tokens[0];
                result.LastName = tokens[1];
            }
            else if(tokens.Length > 2)
            {
                result.FirstName = tokens[0];
                for(int i=1;i<tokens.Length;i++)
                {
                    result.LastName+=" "+tokens[i];
                }
                
            }
            return result;
        }
    }
}
