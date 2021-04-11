using AutoMapper;
using Newtonsoft.Json;
using NUnit.Framework;
using test.console;

namespace Test.Nunit
{
    [TestFixture]
    public class TestsHi
    {
        [Test]
        public void Test1()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Model, ModelDto>();
            });
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            var model = new Model();
            var json = JsonConvert.SerializeObject(model);
            Assert.Pass();
        }
    }
}