using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Models
{
    [Table("VehicleFeature")]
    public class VehicleFeature
    {
        public int VehicleId { get; set; }
        public int FeatureId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Feature Feature { get; set; }
    }
}