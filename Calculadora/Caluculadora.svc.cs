﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculadora
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : ICalculadora
    {
        public float operar(Operaciones operaciones)
        {
            float resultado = 0;
            switch (operaciones.Operacion)
            {
                case "+":
                    resultado = operaciones.Numero1 + operaciones.Numero2;
                    break;
                case "-":
                    resultado = operaciones.Numero1 - operaciones.Numero2;
                    break;
                case "*":
                    resultado = operaciones.Numero1 * operaciones.Numero2;
                    break;
                case "/":
                    resultado = operaciones.Numero1 / operaciones.Numero2;
                    break;
            }
            return resultado;
        }
    }
}
