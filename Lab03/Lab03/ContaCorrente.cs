using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03 {
    public class ContaCorrente {
        private string nome;
        private decimal saldo;
        public ContaCorrente(string nome) {
            this.nome = nome;
        }
        public ContaCorrente(string nome, decimal saldo) {
            this.saldo = saldo; 
            this.nome = nome;
        }
        public void Depositar(decimal valor) {
            saldo += valor;
        }
        public void Sacar(decimal valor) {
            if (valor <= saldo)
                saldo -= valor;
        }

        public string Nome {
            get { return nome; }
            set { nome = Nome; }
        }
        public decimal Saldo {
            get { return saldo; }
            set { saldo = Saldo; }
        }
            
    }
}
