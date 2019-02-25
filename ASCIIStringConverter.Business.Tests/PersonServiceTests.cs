using ASCIIStringConverter.Business;
using ASCIIStringConverter.Common.Models;
using ASCIIStringConverter.Data.Entities;
using ASCIIStringConverter.Data.Repository;
using AutoMapper;
using Moq;
using NUnit.Framework;
using System.Collections;
using System.Threading.Tasks;

namespace Tests
{
    public class PersonServiceTest
    {
        public class MyDataClass
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(new PersonVM() { FullName = "Ann Other"}).Returns(2);
                    yield return new TestCaseData(new PersonVM() { FullName = "Ann O"}).Returns(3);
                    yield return new TestCaseData(new PersonVM() { FullName = "Rama"}).Returns(6);
                }
            }
        }

        [SetUp]
        public void Setup()
        {

        }

        [TestCaseSource(typeof(MyDataClass), "TestCases")]
        public async Task<int> PersonService_TestHandle(PersonVM personVM)
        {
            var mockRepo = new Mock<IPersonRepository>();
            mockRepo.Setup(m => m.InsertPerson(new ASCIIStringConverter.Data.Entities.Person()));
            var mockAM = new Mock<IMapper>();
            mockAM.Setup(x => x.Map<PersonVM, Person>(It.IsAny<PersonVM>()))
                        .Returns(new Person() { FirstName = "Ann", LastName = "Other" });
            var service = new PersonService(mockRepo.Object, mockAM.Object);
            var result = await service.Handle(personVM);
            return result.ZeroCntInBinASCIIName;
            //Assert.AreEqual(3, result.ZeroCntInBinASCIIName);

        }
    }
}