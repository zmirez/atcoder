using System;
class Problem01{
	static void Main(string []args){
		string [] t=(Console.ReadLine()).Split(' ');
		int a=int.Parse(t[0]);
		int b=int.Parse(t[1]);
		int c=int.Parse(t[2]);
		int d=int.Parse(t[3]);
		if(Math.Abs(a-c)<=d){
			Console.WriteLine("Yes");
		}else if(Math.Abs(a-b)<=d && Math.Abs(b-c)<=d){
			Console.WriteLine("Yes");
		}else {
			Console.WriteLine("No");
		}
	}
}