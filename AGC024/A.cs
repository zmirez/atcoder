using System;
class A{
    static void Main(string []args){
        string []t=Console.ReadLine().Split(' ');
        long A=long.Parse(t[0]);
        long B=long.Parse(t[1]);
        long C=long.Parse(t[2]);
        ulong K=ulong.Parse(t[3]);
        if(A==B){
                Console.WriteLine(0);
                return;
        }else if(K==0){
            Console.WriteLine(A-B);
        }else if(Math.Abs(A-B)>Math.Pow(10,18)){
            Console.WriteLine("Unfair");
            return;
        }else if(K%2==0){
            Console.WriteLine(A-B);
        }else if(K%2!=0){
            Console.WriteLine(B-A);
        }
    }
}