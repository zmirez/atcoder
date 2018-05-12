using System;
class Problem02{
	static void Main(string []args){
		string t=Console.ReadLine();
		int X=int.Parse(t);
		for(int i=X;i>=1;i--){
			if(beki(i)==true){
				Console.WriteLine(i);
				break;
			}
		}
	}
	static bool beki(int x){
			if(x==1) return true;
		for(int i=2;i<=x/2;i++){
			if(x%i!=0) continue;
			int n=x;
			for(int j=2;n>=0;j++){
				n /= i;
				if(n==1)return true;
				else if(n%i!=0)break;
			}
		}
		return false;
	}
}