using System;
using System.Globalization;

namespace PrimeiroProjeto {
    class ConversorDeMoeda {
        public static double Iof = 6.0;

        public static double ValorEmReais(double cotacao, double quantidade) {
            double valor = cotacao * quantidade;
            return valor + valor * Iof / 100.0;
        }
    }
}
