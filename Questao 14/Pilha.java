//questão14 parteII

public class Pilha{
    
    private int top;
    private Object stack[];
    public int length;

    public Pilha(int length){
        stack = new Object[length];
        top = -1;
    }

    public void push(String obj){
        if(isFull()){
            System.out.println("está cheia");
        }
        else{
                stack[++top] = obj;
        }
    }

    public Object pop(){
        if(isEmpty()){
            return null;
        }
        else{
            Object x = stack[top];
            stack[top] = null;
            top--;
            return x;
        }
    }
    
    public int top(){
        return this.top;
    }


    public boolean isEmpty(){
        if(this.top < 0){
        return true;
    }
        return false;
    }
   


    public boolean isFull(){
        if(this.top == stack.length-1){
            return true;
        }
        return false;
    }


    public void show(){
        if(isEmpty()){
            System.out.println("pilha vazia");
        }else{
        for(int i = this.top; i>=0; i--){
            System.out.println(stack[i]);
        }
    }
    }

    public Object topShow(){
        if(isEmpty()){
            return null;
        }
        return this.stack[length];
    }


 }
    






