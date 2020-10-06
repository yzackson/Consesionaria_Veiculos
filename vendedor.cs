using System;

class Vendedor {
    double salario;
    double comissao;

    public double ReceberSalario(double valor_de_vendas) {
        return (salario + (comissao*valor_de_vendas));
    }
}