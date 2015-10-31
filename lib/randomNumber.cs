using System;
using System.Collections.Generic;
using System.Text;
//the namespace must be PAT.Lib, the class and method names can be arbitrary
namespace PAT.Lib
{
    /// <summary>
    /// This is a Random Number Generator Library
    /// 
    /// e.g. call(randomNumber, 4, 10),
    ///
    /// </summary>
    public class RandomNumber
    {
    	/**
    	 * Returns a Random number in the range of a and b inclusive.
    	 * Inputs are to be greater than 0, otherwise they will be 
    	 * forced to 0.
    	 * If a is greater than b, the inputs would be swapped.
    	 */
		public static int randomNumber(int a, int b)
		{
        	if (a < 1)
        	{
        		a = 1;
        	}
        	if (b < 1)
        	{
        		b = 1;
        	}
        	if (a > b)
        	{
        		int temp = a;
        		a = b;
        		b = temp;
        	}
        	Random rnd = new Random();
			return rnd.Next(a, b);   // creates a number between a and b
        }
    }
}
