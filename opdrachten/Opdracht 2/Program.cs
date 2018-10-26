using System;

class Program
{
    public static int Fibonacci(int n)
    {
        int a = 0;
        int b = 1;
        // In N steps compute Fibonacci sequence iteratively.
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }
    
  public static int Factorial( int x ){
  if( x<0){
     return -1;
  }else if( x==1 || x==0 )
  {
     return 1;
  }else{
     return x* Factorial(x-1);
  }
}

static void Main()
    {
        //Fibonacci sequence under this comment
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
        //Factorials under this comment
        int e = 5;
        Console.WriteLine(Factorial(e));
        //Multiplication table under this comment
        int o = 3;
        int p = 3;
        
        for(int i = 0; i<=o; i++)
        {
            int uitkomst = i*p;
            Console.WriteLine(uitkomst);
            
        }
    }

}