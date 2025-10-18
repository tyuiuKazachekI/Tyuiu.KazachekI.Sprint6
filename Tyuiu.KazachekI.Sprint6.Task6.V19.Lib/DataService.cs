using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KazachekI.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path)) return string.Empty;

            // Считаем весь текст и разобьем на слова по пробелам
            string text = File.ReadAllText(path);
            var words = text.Split(new char[] { ' ', '\t', '\n', '\r' },
                                    System.StringSplitOptions.RemoveEmptyEntries);

            // Оставим только слова, содержащие 'l' или 'L'
            var filtered = words.Where(w => w.Contains('l') || w.Contains('L'));

            // Объединим в одну строку через пробел
            return string.Join(" ", filtered);
        }
    }
}
