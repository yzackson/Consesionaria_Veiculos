using System;

class main {
    public static void Main(string[] args) {
        vendedor carlos = new vendedor("Carlos", 2000.34, 1.34);

        veiculo uno = new veiculo("Fiat", 2020, 5000, 0);

        mostruario secaoA = new mostruario(carlos);

        secaoA.carros.Add(uno);

        double soma = 0;

        for (int i = 0; i < secaoA.carros.Count; i++){
            soma+=secaoA.carros[i].getValor();
        }

        Console.WriteLine("SOMA >> {0}", soma);
    }
}