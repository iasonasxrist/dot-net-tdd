﻿using System;

public static class StringHandler
{
	/// <summary>
	/// Inserts spaces before each capital letter
	/// </summary>
	/// <param name="source"></param>
	/// <returns></returns>
	public static string InsertSpaces(this string source)
	{

		string result = string.Empty;
	
		if (!String.IsNullOrWhiteSpace(source))
		{
            foreach (char letter in source)
            {
				if (char.IsUpper(letter))
				{
					result = result.Trim();
					result += " ";
				}

                result += letter;

            }
			result = result.Trim();
			
		}
        return result;
    }
}


