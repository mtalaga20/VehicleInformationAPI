using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace VehicleInformationAPI.Models.Entities
{
    public class VehicleEquipment
    {
        [Required]
        public int Id { get; set; }

        public string EquipmentName { get; set; }
        
        public string Price { get; set; }

        public string EquipmentClass { get; set; }

        public string? ModelYearId { get; set; }

        public string? StyleId { get; set; }
    }
}
