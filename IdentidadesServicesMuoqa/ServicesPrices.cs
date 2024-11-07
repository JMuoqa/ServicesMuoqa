using System.ComponentModel.DataAnnotations;

namespace IdentidadesServicesMuoqa
{
    public class ServicesPrices
    {
        [Key]
        public int? ServiceId { get; set; } = null;
        public string ServiceName { get; set; }
        public string ServicePrice { get; set; }
        public string ServiceActive { get; set; } = "NO";
    }
}
