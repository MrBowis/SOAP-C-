using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculadora
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICalculadora
    {

        [OperationContract]
        float operar(Operaciones operaciones);
    }

    [DataContract]
    public class Operaciones
    {
        private float numero1;
        private float numero2;
        private string operacion;
        private float resultado;

        [DataMember]
        public float Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        [DataMember]
        public float Numero1
        {
            get { return numero1; }
            set { numero1 = value; }
        }

        [DataMember]
        public float Numero2
        {
            get { return numero2; }
            set { numero2 = value; }
        }

        [DataMember]
        public string Operacion
        {
            get { return operacion; }
            set { operacion = value; }
        }
    }
}
