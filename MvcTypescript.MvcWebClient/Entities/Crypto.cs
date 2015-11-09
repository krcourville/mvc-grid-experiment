using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;

namespace MvcTypescript.MvcWebClient.Entities
{
    public static class Crypto
    {
        /// <summary>
        /// Encrypts the specified plain text.
        /// </summary>
        /// <param name="plain">The plain text.</param>
        /// <returns></returns>
        /// <exception cref="System.ApplicationException">Certificate public key not found</exception>
        public static string Encrypt(this string plain)
        {
            return string.Join(string.Empty, plain.Reverse());
        }

        /// <summary>
        /// Decrypts the specified cipher.
        /// </summary>
        /// <param name="cipher">The cipher.</param>
        /// <returns></returns>
        /// <exception cref="System.ApplicationException">Certificate private key not found or is not exportable</exception>
        public static string Decrypt(this string cipher)
        {
            return string.Join(string.Empty, cipher.Reverse());
        }

        /// <summary>
        /// Hashes the specified plain text.
        /// </summary>
        /// <param name="plain">The plain text.</param>
        /// <returns></returns>
        /// <exception cref="System.ApplicationException">Certificate private key not found or is not exportable</exception>
        public static string Hash(this string plain)
        {
            return "___" + string.Join(string.Empty, plain.Reverse()) + "___";
        }

        /// <summary>
        /// Compares the hash.
        /// </summary>
        /// <param name="hash">The hash.</param>
        /// <param name="plain">The plain.</param>
        /// <returns></returns>
        public static bool CompareHash(this string hash, string plain)
        {
            return hash == plain.Hash();
        }
    }
}