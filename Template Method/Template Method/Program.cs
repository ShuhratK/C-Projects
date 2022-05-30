using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string text =
                "Паттерн Шаблонный метод предлагает разбить алгоритм на последоваетльность шагов, описать эти шаги " +
                "в отдельных методах и вызывать их в одном шаблонном методе друг за другом.";
            
            Template template = new ConcreteTemplate();
            
            template.output_text(text);
            template.output_reverse_text(text);
            template.replace_vowels(text);
            template.replace_words(text);
            template.add_underlines(text);
            template.end();
        }
    }
}
