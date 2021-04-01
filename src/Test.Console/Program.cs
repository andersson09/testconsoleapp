using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using hello;

namespace test.console
{
    //Test1
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection();
            Console.WriteLine("DI Test");

            //async test
            var service = new TestService();

            Console.WriteLine(service.Run("Dan"));

            await Task.Delay(5000);
            Console.WriteLine(service.Run("Sonia"));

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Model, ModelDto>();
            });

            var mapper = config.CreateMapper();

            var modelA = new Model
            {
                Message = "AutomapperTest"
            };

            var modelDto = mapper.Map<Model, ModelDto>(modelA);

            Console.WriteLine(modelDto.Message);

            var modelB = new Model
            {
                Message = "JsonTest"
            };

            var json = JsonConvert.SerializeObject(modelB);
            Console.WriteLine(json);

            var message = new YoService();
            var hi = message.Send("bob");
            Console.WriteLine(hi);
        }
    }
}
