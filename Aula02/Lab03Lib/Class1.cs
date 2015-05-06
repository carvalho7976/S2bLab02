using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Lib {
    public class ContaCorrente {
        private string nome;
        private decimal saldo;
        private DateTime data;
        public ContaCorrente(string nome) {
            this.nome = nome;
        }
        public ContaCorrente(string nome, decimal saldo) {
            this.saldo = saldo;
            this.nome = nome;
        }
        public void Depositar(decimal valor) {
            saldo += valor;
            data = DateTime.Now;
        }
        public void Sacar(decimal valor) {
            if (valor <= saldo) {
                saldo -= valor;
                data = DateTime.Now;
            }
                
        }

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }
        public decimal Saldo {
            get { return saldo; }
            set { saldo = value; }
        }
        public DateTime Data {
            get { return data; }
            set { data = value; }
        }
    }
}
