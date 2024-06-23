using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TextEditor
    {
        private Document document;

        public TextEditor()
        {
            document = new Document();
        }

        public void AddDocument(string text)
        {
            document.Add(text);
        }

        public void RemoveDocument()
        {
            document.Remove();
        }

        public void EditDocument(string newText)
        {
            document.Edit(newText);
        }

        public void CountWords()
        {
            int count = document.WordCount();
            Console.WriteLine($"Word count: {count}");
        }

        public void CountChars()
        {
            int count = document.CharCount();
            Console.WriteLine($"Character count: {count}");
        }

        public void RemoveWord(string wordToRemove)
        {
            document.RemoveWord(wordToRemove);
        }

        public void ReplaceWord(string oldWord, string newWord)
        {
            document.ReplaceWord(oldWord, newWord);
        }

        public void ClearDocument()
        {
            document.Remove();
        }

        public void AddHyphenBetweenWords()
        {
            document.AddHyphenBetweenWords();
        }

        public void DisplayDocument()
        {
            document.Display();
        }
    }

}
