import java.util.Scanner;

public class Principal {
    public static void main(String[] args) {
    
    int valor;
    Scanner ler= new Scanner(System.in);
    valor = ler.nextInt();

    Pi pi = new Pi();
    pi.calculoPi(valor);

    Euler e = new Euler();
    e.calculoEuler(valor);

    RaizN r = new RaizN();
    r.calcularRaiz(valor);

}
}