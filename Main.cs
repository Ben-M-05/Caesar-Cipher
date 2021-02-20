using System;

//main file
class main {
    public static void Main(String[] args) {
      //user input
       Console.WriteLine("Enter some text: \n");
       string user_input = Console.ReadLine();
       Console.WriteLine("Input a key: \n");
       int key = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine(key);
       Console.WriteLine('\n');

       //cipher
       string cipherEncrypt = AutoCipher.Ciphering(user_input, key);

      //output
       Console.WriteLine("Encrypted text: " + cipherEncrypt);
       Console.WriteLine('\n');
       string decipher = AutoCipher.Decrypting(cipherEncrypt, key);
       Console.WriteLine("Decyphered text: " + decipher);
       Console.WriteLine('\n');

       //brute force code
       Brute.force(cipherEncrypt);
       Brute.Analysis(cipherEncrypt);


      //key encryption 
       string testing = Generate.AdvEncrypt(cipherEncrypt);
       Console.WriteLine("encrypted data 1: " + testing);
       Console.WriteLine('\n');
       Console.WriteLine(Generate.AdvDecrypt(testing, key));
       
    }
}