using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesServicesRepository(IServiceCollection serviceColletion)
        {
            serviceColletion.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceColletion.AddDbContext<MyContext>
            (
                options => options.UseMySql(
                    "Server=LocalHost;Port=3306;DataBase=dbAPI;Uid=root;Pwd=1234",
                    new MySqlServerVersion(new Version("8.0.33")))
            );
        }
    }
}
