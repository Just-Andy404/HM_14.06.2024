namespace ConsoleApp1
{
    internal class EngFrDictionary
    {
        private Dictionary<string, List<string>> _dict;

        public EngFrDictionary()
        {
            _dict = new Dictionary<string, List<string>>();
        }

        public void AddNewWord(string word, string translation)
        {
            if (!_dict.ContainsKey(word))
            {
                _dict[word] = new List<string>();
            }
            if (!_dict[word].Contains(translation))
            {
                _dict[word].Add(translation);
            }
        }

        public void AddNewWord(string word, List<string> translations)
        {
            if (!_dict.ContainsKey(word))
            {
                _dict[word] = new List<string>();
            }
            foreach (var translation in translations)
            {
                if (!_dict[word].Contains(translation))
                {
                    _dict[word].Add(translation);
                }
            }
        }

        public void AddTranslation(string word, string translation)
        {
            if (_dict.ContainsKey(word))
            {
                if (!_dict[word].Contains(translation))
                {
                    _dict[word].Add(translation);
                }
            }
            else
            {
                AddNewWord(word, translation);
            }
        }

        public string Translate(string word)
        {
            if (_dict.ContainsKey(word))
            {
                return string.Join(", ", _dict[word]);
            }
            else
            {
                return "Слово не найдено в словаре.";
            }
        }

        public void DeleteWord(string word)
        {
            _dict.Remove(word);
        }

        public void DeleteTranslations(string word)
        {
            if (_dict.ContainsKey(word))
            {
                _dict[word].Clear();
            }
        }

        public void ChangeTranslation(string word, string newTranslation)
        {
            if (_dict.ContainsKey(word))
            {
                _dict[word].Clear();
                _dict[word].Add(newTranslation);
            }
        }

        public static EngFrDictionary operator +(EngFrDictionary dict1, EngFrDictionary dict2)
        {
            foreach (var item in dict2._dict)
            {
                dict1.AddNewWord(item.Key, item.Value);
            }
            return dict1;
        }

        public override string ToString()
        {
            var result = new System.Text.StringBuilder();
            result.AppendLine("English-French Dictionary:");
            foreach (var item in _dict)
            {
                result.AppendLine($"Word: {item.Key}");
                result.AppendLine($"Translation: {string.Join(", ", item.Value)}");
            }
            return result.ToString();
        }
    }
}
