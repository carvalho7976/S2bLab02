using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Lab14_classLibrary;

namespace Lab14_service {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1 {
        public string SimpleMethod(string s) {
            return "Hello " + s;
        }
        public JogoFutebol[] ComplexMethod() {
            JogoFutebol[] resultadoJogo = new JogoFutebol[2];

            resultadoJogo[0] = new JogoFutebol();
            resultadoJogo[0].casa = "Barcelona";
            resultadoJogo[0].visitante = "Bayern";
            resultadoJogo[0].golCasa = 3;
            resultadoJogo[0].golVisitante = 0;

            resultadoJogo[1] = new JogoFutebol();
            resultadoJogo[1].casa = "Barcelona";
            resultadoJogo[1].visitante = "Chapecoense";
            resultadoJogo[1].golCasa = 0;
            resultadoJogo[1].golVisitante = 2;

            return resultadoJogo;
        }
    }
}
