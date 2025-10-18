using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KazachekI.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        // Чтение всего текста из файла
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path)) return string.Empty;
            return File.ReadAllText(path);
        }

        // Возвращает только слова, содержащие букву 'l' (регистр не важен)
        public string GetWordsWithL(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;

            var words = text
                .Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', '!', '?', ';', ':' }, System.StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.ToLower().Contains('l'))
                .ToArray();

            return string.Join(" ", words);
        }
    }
}
