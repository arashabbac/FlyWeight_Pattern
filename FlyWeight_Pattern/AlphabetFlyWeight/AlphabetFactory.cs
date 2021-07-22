namespace FlyWeight_Pattern.AlphabetFlyWeight
{
    public static class AlphabetFactory
    {
        static System.Collections.Generic.Dictionary<string, Alphabet> dictionary;

        static AlphabetFactory()
        {
            dictionary = new System.Collections.Generic.Dictionary<string, Alphabet>();
        }

        public static Alphabet GetAlphabet(string key)
        {
            if(dictionary.ContainsKey(key) == false)
            {
                Alphabet alphabet = null;

                switch (key)
                {
                    case "A":
                        alphabet = new AAlphabet();
                        break;

                    case "B":
                        alphabet = new BAlphabet();
                        break;
                }

                dictionary[key] = alphabet;
            }

            return dictionary[key];
        }
    }
}
