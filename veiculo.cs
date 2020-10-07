using System;

class veiculo {
    string marca;
    int ano;
    double valor;
    int km;

    // Função que atualiza o valor
    public void atualizaValor(int ano) {
        this.valor = this.valor - ((ano - this.ano)*2.05);
    }

    // Função para mostrar na tela os valores
    public void relatorio() {
        Console.WriteLine("Marca: {0}\nAno: {1}\nValor: {2}\nKm: {3}\n", marca, ano, valor, km);
    }

    // Função que "cria" novo veículo
    public veiculo(string marca, int ano, double valor, int km) {
        this.marca = marca;
        this.ano = ano;
        this.valor = valor;
        this.km = km;
    }

    public double getValor(){
        return valor;
    }
}