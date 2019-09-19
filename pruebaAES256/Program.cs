using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

using pruebaAES256;

namespace Aes_Example
{
    class AesExample
    {
        public static void Main()
        {
            //pruebasMetodo1();
            string textoPlano= "Texto para encriptar";
            string textoClave = "Esto es una clave";


            string encriptado  = AESCrypto.Encrypt(textoPlano, textoClave);
            Console.WriteLine("Texto plano: {0}", textoPlano);
            Console.WriteLine("Encrypted: {0}", encriptado);
            string desencriptado = AESCrypto.Decrypt(encriptado, textoClave);
            Console.WriteLine("Desencriptado: {0}",desencriptado);
            Console.ReadKey();



        }

    static public void pruebasMetodo1()
    {
        string original = "Here is some data to encrypt!";

        // Create a new instance of the AesManaged
        // class.  This generates a new key and initialization 
        // vector (IV).
        using (AesManaged myAes = new AesManaged())
        {
            //Establece el tamaño de la clave en 256
            myAes.KeySize = 256;

            // Encrypt the string to an array of bytes.
            byte[] encrypted = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV);

            // Decrypt the bytes to a string.
            string roundtrip = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

            //Display the original data and the decrypted data.
            Console.WriteLine("Original:   {0}", original);
            Console.WriteLine("Encrypted: {0}", Encoding.Default.GetString(encrypted));
            Console.WriteLine("Round Trip: {0}", roundtrip);
            Console.ReadKey();
        }
    }


        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an AesManaged object
            // with the specified key and IV.
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            // Return the encrypted bytes from the memory stream.
            return encrypted;

        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an AesManaged object
            // with the specified key and IV.
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }
    }
}
