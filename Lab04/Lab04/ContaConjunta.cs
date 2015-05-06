using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab04 {
    public class ContaConjunta : Conta {
        private string titular01;
        private string titular02;
        public const decimal TaxaContaConjunta = 0.02M;
        public ContaConjunta(string titular01, string titular02) {
            this.titular01 = titular01;
            this.titular02 = titular02;
        }
        public override string Id {
            get { return titular01 + "_" + titular02 + " (CJ)"; }
        }
        public override void Depositar(decimal valor) {
            decimal desconto = valor * TaxaContaConjunta;
            base.Depositar(valor - valor);
        }
        public override void Sacar(decimal valor) {
            decimal desconto = valor * TaxaContaConjunta;
            base.Sacar(valor + TaxaContaConjunta);
        }
    }
}