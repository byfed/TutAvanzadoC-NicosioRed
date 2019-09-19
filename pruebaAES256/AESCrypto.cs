using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace pruebaAES256
{
    class AESCrypto
    {
        //Se genera un salt para añadir al texto antes de codigo
        private static readonly int _saltSize = 32;

         public static string Encrypt(string plainText, string key)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException("plainText");
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException("key");

            // Obtiene una sal y un vector de inciialización de la clave
            using (var keyDerivationFunction = new Rfc2898DeriveBytes(key, _saltSize))
            {
                var saltBytes = keyDerivationFunction.Salt;
                // La longitud de la clave con 32bytes es de 256bits (AES 256). Para AES son válidos tamaños de clave de 128,192 o 256, que 
                // corresponden con llamadas a la función siguiente con parámetro 16, 24 y 32 respectivamente.
                var keyBytes = keyDerivationFunction.GetBytes(32);
                var ivBytes = keyDerivationFunction.GetBytes(16);

                // Create an encryptor to perform the stream transform.
                // Create the streams used for encryption.
                using (var aesManaged = new AesManaged())
                using (var encryptor = aesManaged.CreateEncryptor(keyBytes, ivBytes))
                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    using (var streamWriter = new StreamWriter(cryptoStream))
                    {
                        // Send the data through the StreamWriter, through the CryptoStream, to the underlying MemoryStream
                        streamWriter.Write(plainText);
                    }

                    // Return the encrypted bytes from the memory stream, in Base64 form so we can send it right to a database (if we want).
                    var cipherTextBytes = memoryStream.ToArray();
                    Array.Resize(ref saltBytes, saltBytes.Length + cipherTextBytes.Length);
                    Array.Copy(cipherTextBytes, 0, saltBytes, _saltSize, cipherTextBytes.Length);

                    return Convert.ToBase64String(saltBytes);
                }
            }
        }

        public static string Decrypt(string ciphertext, string key)
        {
            if (string.IsNullOrEmpty(ciphertext))
                throw new ArgumentNullException("cipherText");
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException("key");

            // Extract the salt from our ciphertext
            var allTheBytes = Convert.FromBase64String(ciphertext);
            var saltBytes = allTheBytes.Take(_saltSize).ToArray();
            var ciphertextBytes = allTheBytes.Skip(_saltSize).Take(allTheBytes.Length - _saltSize).ToArray();

            using (var keyDerivationFunction = new Rfc2898DeriveBytes(key, saltBytes))
            {
                // Derive the previous IV from the Key and Salt
                var keyBytes = keyDerivationFunction.GetBytes(32);
                var ivBytes = keyDerivationFunction.GetBytes(16);

                // Create a decrytor to perform the stream transform.
                // Create the streams used for decryption.
                // The default Cipher Mode is CBC and the Padding is PKCS7 which are both good
                using (var aesManaged = new AesManaged())
                using (var decryptor = aesManaged.CreateDecryptor(keyBytes, ivBytes))
                using (var memoryStream = new MemoryStream(ciphertextBytes))
                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                using (var streamReader = new StreamReader(cryptoStream))
                {
                    // Return the decrypted bytes from the decrypting stream.
                    return streamReader.ReadToEnd();
                }
            }
        }
    }
}


        

