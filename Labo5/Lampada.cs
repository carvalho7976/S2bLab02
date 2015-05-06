using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labo5 {
    public class Lampada : IEstadoBinario {
        private bool ligado;
        private double voltagem;
        private double potencia;
        public Lampada(double voltagem, double potencia ) {
            this.voltagem = voltagem;
            this.potencia = potencia;
        }
        public double Voltagem {
            get{ return voltagem;}
        }
        public double Potencia {
            get { return potencia; }
        }
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