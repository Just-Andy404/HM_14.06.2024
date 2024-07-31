//Создайте приложение "Англо-французский словарь", которое должно
//сохранять следующую информацию:
// слово на английском языке;
// варианты перевода на французский язык.
//Для хранения информации используйте Dictionary<T>.
//Приложение должно предоставлять следующую функциональность:
// добавить слово и варианты перевода;
// удалить слово;
// удалить варианты перевода;
// изменение слова;
// изменение варианта перевода;
// поиск перевода слова; // поиск перевода слова.
using ConsoleApp1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EngFrDictionary dict = new EngFrDictionary();
            dict.AddNewWord("Hello", "Bonjour");
            dict.AddNewWord("Book", "Livre");
            dict.AddTranslation("Book", "Réserver");
            DisplayDictionary(dict);

            dict.AddNewWord("Match", "Correspondre");
            dict.AddTranslation("Match", "Allumette");
            dict.AddTranslation("Match", "Match");
            DisplayDictionary(dict);

            dict.ChangeTranslation("Match", "Correspondre");
            DisplayDictionary(dict);

            string word = "Hello";
            Console.WriteLine($"{word} translation: {dict.Translate(word)}");
            dict.DeleteWord(word);
            DisplayDictionary(dict);

            EngFrDictionary dict2 = new EngFrDictionary();
            dict2.AddNewWord("Fair", "Juste");
            dict2.AddNewWord("Right", "Droit");
            dict2.AddNewWord("Left", "Gauche");
            dict += dict2;
            DisplayDictionary(dict);
        }

        static void DisplayDictionary(EngFrDictionary dictionary)
        {
            Console.WriteLine(dictionary);
            Console.WriteLine("====================");
        }
    }
}
