using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace EzyFindMobileApi.Model
{
    public class EncryptDecrypt
    {
        private ASCIIEncoding MyASCIIEncoding = new ASCIIEncoding();
        private static TripleDESCryptoServiceProvider cryptDES3 = new TripleDESCryptoServiceProvider();
        private static MD5CryptoServiceProvider cryptMD5Hash = new MD5CryptoServiceProvider();

        public EncryptDecrypt()
        {
            //
            // TODO: Add constructor logic here

            //
        }

        public static string Encrypt(string phrase)
        {
            string decodedPhrase;

            byte[] Buff;

            cryptDES3.Key = cryptMD5Hash.ComputeHash(ASCIIEncoding.ASCII.GetBytes(phrase));

            cryptDES3.Mode = CipherMode.ECB;

            ICryptoTransform desdencrypt = cryptDES3.CreateDecryptor();

            Buff = ASCIIEncoding.ASCII.GetBytes(phrase);

            decodedPhrase = Convert.ToBase64String(Buff, 0, Buff.Length);

            return decodedPhrase;
        }

        public static string Decrypt(string phrase)
        {
            string encodedPhrase;

            byte[] Buff;

            cryptDES3.Key = cryptMD5Hash.ComputeHash(ASCIIEncoding.ASCII.GetBytes(phrase));

            cryptDES3.Mode = CipherMode.ECB;

            ICryptoTransform desdencrypt = cryptDES3.CreateDecryptor();

            Buff = Convert.FromBase64String(phrase);

            //encodedPhrase = ASCIIEncoding.ASCII.GetString(desdencrypt.TransformFinalBlock(Buff, 0, Buff.Length));

            encodedPhrase = ASCIIEncoding.ASCII.GetString(Buff, 0, Buff.Length);

            return encodedPhrase;
        }

        ///// <summary>
        ///// Encrypt the Message with symmetric key
        ///// </summary>
        ///// <param name="Message">string to be encrypt using TripleDES</param>
        ///// <param name="key">string key to encrypt</param>
        ///// <returns>string</returns>
        //public static string EncryptString(string p_Password)
        //{
        //    string key = System.Configuration.ConfigurationManager.AppSettings["securityKey"].ToString();

        //    byte[] Results;
        //    System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

        //    // Step 1. We hash the passphrase using MD5
        //    // We use the MD5 hash generator as the result is a 128 bit byte array
        //    // which is a valid length for the TripleDES encoder we use below

        //    MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
        //    byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(key));

        //    // Step 2. Create a new TripleDESCryptoServiceProvider object
        //    TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

        //    // Step 3. Setup the encoder
        //    TDESAlgorithm.Key = TDESKey;
        //    TDESAlgorithm.Mode = CipherMode.ECB;
        //    TDESAlgorithm.Padding = PaddingMode.PKCS7;

        //    // Step 4. Convert the input string to a byte[]
        //    byte[] DataToEncrypt = UTF8.GetBytes(p_Password);

        //    // Step 5. Attempt to encrypt the string
        //    try
        //    {
        //        ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
        //        Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
        //    }
        //    finally
        //    {
        //        // Clear the TripleDes and Hashprovider services of any sensitive information
        //        TDESAlgorithm.Clear();
        //        HashProvider.Clear();
        //    }

        //    // Step 6. Return the encrypted string as a base64 encoded string
        //    return Convert.ToBase64String(Results);
        //}

        /// <summary>
        /// Decrypt the Message with symmetric key using TripleDES
        /// </summary>
        /// <param name="Message">string encrypted message using key</param>
        /// <param name="key">string symmetric key to decrypt</param>
        /// <returns></returns>
        public static string DecryptString(string p_Password)
        {
            // string key = System.Configuration.ConfigurationManager.AppSettings["securityKey"].ToString();
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the key using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes("key"));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the decoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToDecrypt = Convert.FromBase64String(p_Password);

            // Step 5. Attempt to decrypt the string
            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the decrypted string in UTF8 format
            return UTF8.GetString(Results);
        }
    }
}

public class Response
{
    
    public bool Status { get; set; }

    
    public string Message { get; set; }

    
    public Object Result { get; set; }

    
    public int Count { get; set; }

    public int TotalPages { get; set; }

    public int CurrentPage { get; set; }

    public int PrevPage { get; set; }

    public int NextPage { get; set; }
}



//// Instantiate Dictionary                    
//ClientResponse = new Dictionary<string, object>();
//        // Add Response
//        ClientResponse.Add("Response", response);

//  response.Status = false;                // Operation Status Indicator
//            response.Message = exception.Message;   // Exception Message
//            response.Result = null;                 // Result

// response.Status = true;                 // Operation Status Indicator
//                response.Message = "The username or password you entered is incorrect.";        // Message
//                response.Result = "";