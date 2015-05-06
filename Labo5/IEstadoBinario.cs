using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5 {
    public enum EstadoBinario { Ligado, Desligado}
    interface IEstadoBinario {
        void Ligar();
        void Desligar();
        EstadoBinario Estado { get; }
    }
}
