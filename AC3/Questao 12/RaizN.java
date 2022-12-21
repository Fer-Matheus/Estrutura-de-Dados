public class RaizN {
    
    private double raiz;
  

    public RaizN(){
        this.raiz= 0;
    }
    
    public double calcularRaiz(double n){
        double temp=0;
        double r = Math.sqrt(n/2);
        while(r != temp){
        r = Math.sqrt(n/temp + temp)/2;
        }
        return r;
    }
}
