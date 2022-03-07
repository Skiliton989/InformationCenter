using InformationCenter.Models.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InformationCenter.Models
{
    public class AppCtx : IdentityDbContext<User>
    {
        public AppCtx(DbContextOptions<AppCtx> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<ShiftSchedule> ShiftsSchedule { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<StatusOfEquipment> StatusesOfEquipment { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<ServiceСategory>ServiceСategories { get; set; }
        public DbSet<CompletedWork> CompletedWorks { get; set; }


    }
}
