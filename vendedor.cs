using System;

class vendedor {
    double salario;
    double comissao;
    string nome;

    public double receberSalario(double valor_de_vendas) {
        return (salario + (comissao*valor_de_vendas));
    }

    public vendedor(string nome, double salario, double comissao) {
        this.nome = nome;
        this.salario = salario;
        this.comissao = comissao;
    }

    public string getNome() {
        return nome;
    }

    public void setNome(string nome) {
        this.nome = nome;
    }
}