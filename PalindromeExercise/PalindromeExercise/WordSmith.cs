using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
	public class WordSmith
	{


		public bool IsPalendrome(string str)
		{
			char[] charArray = str.ToCharArray();
			Array.Reverse(charArray);
			var reversed = new string(charArray);

			if (reversed == str)
			{ 
				return true; 
			}
			else
			{
				return false;
			}


		}




	}
}
