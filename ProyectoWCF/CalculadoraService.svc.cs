using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProyectoWCF.DTO;
using Calculadora.Model;

namespace ProyectoWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CalculadoraService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CalculadoraService.svc o CalculadoraService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CalculadoraService : ICalculadoraService
    {
        public void DoWork()
        {
        }

        public decimal EjecutarOperacion(CalculadoraDTO calculadoraDTO) 
        => new Operations(calculadoraDTO.Numero1, calculadoraDTO.Numero2)
               .Calculate(calculadoraDTO.Operacion);
    }
}
