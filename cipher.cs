using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  

// holds all the cipher code 

public class AutoCipher {
    /// <summary>
    /// Shifts each character of the stringy parameter by the number shift parameter
    /// </summary>
    ///<remarks>
    ///the base for the entire program
    ///</remarks>
    ///<param name="stringy">The string of text that is going to be shifted</param>
    ///<param name="shift">The number that will shift the text</param>
    public static string Ciphering(string stringy, int shift) {
        
        string output = string.Empty;
        string input = stringy.ToLower();
        for(int i = 0; i< input.Length; i++) {
            ///<values> shifts the char by the shift value</value>
            char ch = (char)(((int)input[i] + shift - 97) % 26 + 97); 
            if(!Char.IsLetter(input[i])) {
                output += " ";
            } else {
                output += ch;
            }
            
        }
        return output;

    }
        
    
    public static string Decrypting(string encrypted, int shift) {
        return Ciphering(encrypted, 26 - shift);
    }
}