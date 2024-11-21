using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentidadesServicesMuoqa
{
    public class RequestedJobs

    {
        [Key]
        public int? JobId { get; set; } = null;
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; } = "No tiene";
        public string JobName { get; set; }
        public string JobPrice { get; set; }
        public string JobStatus { get; set; }
        public DateTime EntryDate { get; set; } = DateTime.Now;
        public DateTime DeliveryDate { get; set; }

    }
}
