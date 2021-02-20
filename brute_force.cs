using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class Brute {

   public static void force(string data) {
       List<string> output = new List<string>();
        for(int i = 0; i<26; i++) {
            string result = AutoCipher.Decrypting(data, i);
            output.Add(result);
            
           
        }
        output.ForEach(Console.WriteLine);

    }

    public static void Analysis(string sign) {
    
     var characterCount= new Dictionary<char,int>();
     foreach(var c in sign)
    {
      if(characterCount.ContainsKey(c))
        characterCount[c]++;
      else if(!Char.IsLetter(c))
        continue;
      else
        characterCount[c] = 1;
     }
     

    char key = characterCount.FirstOrDefault(x => x.Value == characterCount.Values.Max()).Key; 
     Console.WriteLine("Max key: " + key);
     Console.WriteLine('\n');
     Console.WriteLine("Key {0}, frequent: {1}, frequent two: {2}, frequency 3: {3}", (int)key, (int)'e', (int)'t', (int)'o');
     Console.WriteLine('\n');
     int new_key = (int)key - (int)'e';
     int other_new_key = (int)key - (int)'t';
     int other_other_key = (int)key - (int)'o';
     Console.WriteLine(new_key + " " + other_new_key + " " + other_other_key);
     Console.WriteLine('\n');
     Console.WriteLine("first test: " + AutoCipher.Decrypting(sign, new_key));
     Console.WriteLine('\n');
     Console.WriteLine("Second Test: " + AutoCipher.Decrypting(sign, other_new_key));
     Console.WriteLine('\n');
     Console.WriteLine("Third Test: " + AutoCipher.Decrypting(sign, other_other_key));
     Console.WriteLine('\n');

    }
}