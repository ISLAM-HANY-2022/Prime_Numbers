using System;
using System.Linq;

namespace Prime_Numbers
{
	public static class Program
	{
		public static void Main(string[]args)
 	    {
 	     Console.WriteLine("The First Number :");
 	     int n1 =int.Parse(Console.ReadLine());
 	     Console.WriteLine("The Last Number :");
 	     int n2 = int.Parse(Console.ReadLine());
 	     Console.WriteLine("___________\n");
 	     Console.WriteLine("The Prime Number :");
 	     int j;
 	     bool current = false;
 	     for(;n1 <= n2;n1++)
 	      {
 	     	for( j = 2; j < n1 ;j++)
 	     	{
 	          if(n1 % j==0)
 	          {
 	          current = true;
 	          }
 	        }
 	     	if(current==false)
 	     	{
 	     	 Console.WriteLine(""+j);	
 	     	}
 	     	else
 	     	current = false;
 	     	
 	   	  }
     
          
        }
	}
}