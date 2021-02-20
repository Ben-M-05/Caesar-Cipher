using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;
   public class Generate {
     
     
     public static string AdvEncrypt(string data){
       var key = new RSACryptoServiceProvider(2048);
       RSAParameters rsaPublic = key.ExportParameters(false);  
       RSAParameters rsaPrivate = key.ExportParameters(true);
       byte[] parsed = Encoding.UTF8.GetBytes(data);
       byte[] encrypted = key.Encrypt(parsed, false);
       string stringy = Convert.ToBase64String(encrypted);
       File.WriteAllText(path:@"path", key.ToXmlString(false));
       File.WriteAllText(path:@"path", key.ToXmlString(true));
       return stringy;
    }

    public static string AdvDecrypt(string encryptedData, int shift) {
      var text = File.ReadAllText(path:@"path");
      var key = new RSACryptoServiceProvider();
      Console.WriteLine("encrypted data 2:" + encryptedData);
      Console.WriteLine('\n');
      key.FromXmlString(text);
      Console.WriteLine("Xml string: " +text);
      Console.WriteLine('\n');
      byte[] cipher = Convert.FromBase64String(encryptedData);
      byte[] decrypted = key.Decrypt(cipher, false);
      string final = Encoding.UTF8.GetString(decrypted);
      string output = AutoCipher.Decrypting(final, shift);
      return output;
    }

    
   }    