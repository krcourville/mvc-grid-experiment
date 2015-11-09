namespace MvcTypescript.MvcWebClient.Entities
{
    public class CryptoString
    {
        public CryptoString() { }
        public CryptoString(string plainText) : this()
        {
            PlainText = plainText;
            Hashed = plainText.Hash();
            Encrypted = plainText.Encrypt();
        }//ctor

        public string PlainText { get; set; }

        public string Hashed { get; set; }

        public string Encrypted { get; set; }

        public CryptoString Encrypt()
        {
            if (string.IsNullOrWhiteSpace(PlainText))
                return this;
            Encrypted = PlainText.Encrypt();
            return this;
        }
        public CryptoString Hash()
        {
            if (string.IsNullOrWhiteSpace(PlainText))
                return this;
            Hashed = PlainText.Hash();
            return this;
        }

        public static CryptoString GetHash(string plainText)
        {
            return new CryptoString()
            {
                PlainText = plainText,
                Hashed = plainText.Hash()
            };
        }

        public static CryptoString GetEncrypted(string plainText)
        {
            return new CryptoString()
            {
                PlainText = plainText,
                Encrypted = plainText.Encrypt()
            };
        }

        public static CryptoString GetPlainText(string plainText)
        {
            return new CryptoString() { PlainText = plainText };
        }
    }
}