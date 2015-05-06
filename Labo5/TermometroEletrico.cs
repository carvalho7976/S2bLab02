using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labo5 {
    public class TermometroEletrico : Termometro, IEstadoBinario {
        private bool ligado = false;
        public void Ligar() {
            ligado = true;
        }

        public void Desligar() {
            ligado = false;
        }

        public EstadoBinario Estado {
            get { return ligado ? EstadoBinario.Ligado : EstadoBinario.Desligado; }
        }
    }
}