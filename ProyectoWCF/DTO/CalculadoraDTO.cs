using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ProyectoWCF.DTO
{
    [DataContract]
    public class CalculadoraDTO
    {
        [DataMember]
        public decimal Numero1 { get; set; }
        [DataMember]
        public decimal Numero2 { get; set; }
        [DataMember]
        public string Operacion { get; set; }
    }
}