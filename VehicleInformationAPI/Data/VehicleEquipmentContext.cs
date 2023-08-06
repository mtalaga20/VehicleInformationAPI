using Microsoft.EntityFrameworkCore;
using VehicleInformationAPI.Models.Entities;

namespace VehicleInformationAPI.Data
{
    public class VehicleEquipmentContext : DbContext
    {
        public VehicleEquipmentContext(DbContextOptions<VehicleEquipmentContext> options) : base(options) { }

        public DbSet<VehicleEquipment> VehicleEquipment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleEquipment>(x =>
            x.HasKey(x => x.EquipmentName));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}
