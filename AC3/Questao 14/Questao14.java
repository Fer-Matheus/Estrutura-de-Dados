

public class Questao14 {
    

    public static void main(String[] args) {
    
    int [] red, green, blue;
    
    Pilha potes = new Pilha(100);
    Pilha2 kits = new Pilha2(100);


    //funcionario que monta os potes de tres cores
    System.out.println("Produção Funcionario I: ");
    for(int aux=1; aux<30; aux++){
        potes.push("Pote vermelho "+ aux);
        red = new int[aux];
    }


    
    for(int aux2=30; aux2< 55; aux2++){
        potes.push("Pote Verde "+aux2);
        green = new int[aux2];
    }

    for(int aux3=55; aux3<=100; aux3++){
        potes.push("Pote Azul "+aux3);
        blue = new int[aux3];
    }

    potes.show();


    //funcionario que monta os kits com tres potes
    System.out.println("Produção Funcionario II: ");
    
    //Incompleta

    kits.show();
    
}
}
