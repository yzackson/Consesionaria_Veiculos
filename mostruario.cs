using System;

class mostruario {
    string representante;

    public List<veiculo> carros;

    public mostruario(vendedor v){
        representante = v;
        carros = new List<veiculo>();
    }

    public void setRepresentante(vendedor v){
        representante = v;
    }
}