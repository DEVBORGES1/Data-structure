using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filas
{
    // ESta classe representa a fila de chamandos em um CallCenter
    public class IncomingCall
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CallCenter { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Consultant { get; set; }
    }
}