using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab04 {
    public abstract class  Conta {
        private string titular;
        private decimal saldo;
        public Conta(string titular) {
            this.titular = titular;
        }
        public Conta() {
        }

        public decimal Saldo { 
            get { return saldo; } 
        }
        public string Titular { 
            get { return titular; } 
        }
        public abstract string Id {
            get;
        }
        public virtual void Depositar(decimal valor){
            saldo += valor;
        }

        public virtual void Sacar(decimal valor) { 
            if (valor <= saldo)       
                saldo -= valor; 
        } 

    }
}