public class Pi {
    private int n;
    private double pi;

    public Pi(){
        this.pi = 0;
    }

   public void calculoPi(int n){

    int i,k, b,d,c =0;    
    int[] r;
    r = new int[n+100+1];

    for(i=0; i<n+100; i++){
         r[i] = 2000;
    }

    for(k=n+100; k>0; k-=14){
        d=0;
        i = k;
        for(;;){
            d+=r[i]*1000;
            b = 2*i-1;

            r[i]=d%b;
            d/=b;
            i--;
            if(i==0){
                break;
            }
            d = d*i;
        }

        System.out.println("%.4"+ (c+d)/10000);
        c = d%10000;

    }    
     System.out.println("\n");
    }
    
    
}
