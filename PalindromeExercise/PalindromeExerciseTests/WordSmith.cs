using System;
namespace PalindromeExerciseTests
{
	public class WordSmith
	{
		public bool IsAPalidrone(string word, bool expected)
		{
			//throw new Exception();
			string words = "";

			for (int i = word.Length - 1; i >= 0; i--)
			{
				words += word[i];

			}
			var Answer = word == words ? true : false;

			return Answer;

		}
	}
}

