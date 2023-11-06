namespace HomeTask2
{
    internal class Task6
    {
        public static string Encrypt(string text, string key)
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char charToEncrypt = text[i];
                char encryptionKey = key[i % key.Length];

                result[i] = (char)(charToEncrypt ^ encryptionKey);
            }

            return new string(result);
        }

        public static string Decrypt(string text, string key)
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char charToDecrypt = text[i];
                char encryptionKey = key[i % key.Length];

                result[i] = (char)(charToDecrypt ^ encryptionKey);
            }

            return new string(result);
        }
    }
}