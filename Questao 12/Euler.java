public class Euler {

    private int precisao;
    private double euler;

    public Euler(){
        this.euler = 0;
    }

    public void calculoEuler(int precisao){
        double e;
        long count = 0;
        while(precisao<0){
            count++;
            e = Math.pow(1/0/(double) count+1, (double)count);
        }
    }
    
}
