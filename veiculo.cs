using System;

class Veiculo {
    string marca;
    int ano;
    double valor;
    int km;

    // Função que atualiza o valor
    public void AtualizaValor(int ano) {
        this.valor = this.valor - ((ano - this.ano)*2.05);
    }

    // Função para mostrar na tela os valores
    public void relatorio() {
        Console.WriteLine("Marca: {0}\nAno: {1}\nValor: {2}\nKm: {3}\n", marca, ano, valor, km);
    }
}