using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Database
{
    public class MyApplycationContekst : DbContext
    {
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = WeatherStationDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False")
                            .UseSeeding((context, _) =>
                            {
                                var users = context.Set<User>().FirstOrDefault();
                                if (users == null)
                                {
                                    var userFaker = new Faker<User>();
                                    userFaker.RuleFor(x => x.Name, f => f.Name.FullName());
                                    var usersToAdd = userFaker.Generate(1000);

                                    context.AddRange(usersToAdd);
                                    context.SaveChanges();
                                }

                                var sensors = context.Set<Sensor>().FirstOrDefault();
                                if (sensors == null)
                                {
                                    var fakerow = new Faker<Sensor>();
                                    fakerow.RuleFor(x => x.Name, f => f.Name.FullName());
                                    fakerow.RuleFor(x => x.MeasurementDate, faker => faker.Date.Past());
                                    fakerow.RuleFor(x => x.Type, fakers => fakers.Lorem.Word());

                                    var sensorsToAdd = fakerow.Generate(100);
                                    

                                    context.AddRange(sensorsToAdd);
                                    context.SaveChanges();
                                }
                                
                            });
        }
    }
}
