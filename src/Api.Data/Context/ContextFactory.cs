using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var serverVersion = new MySqlServerVersion(new Version("8.0.33"));
            var connectionString = "Server=LocalHost;Port=3306;DataBase=dbAPI;Uid=root;Pwd=1234";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectionString, serverVersion);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
