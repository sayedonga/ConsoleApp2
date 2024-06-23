using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Document
    {
        private string content;

        public Document()
        {
            content = string.Empty;
        }

        public void Add(string text)
        {
            content += text;
        }

        public void Remove()
        {
            content = string.Empty;
        }

        public void Edit(string newText)
        {
            content = newText;
        }

        public int WordCount()
        {
            // Split by spaces to count words
            return content.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public int CharCount()
        {
            // Count characters excluding spaces
            return content.Replace(" ", "").Length;
        }

        public void RemoveWord(string wordToRemove)
        {
            content = content.Replace(wordToRemove, "");
        }

        public void ReplaceWord(string oldWord, string newWord)
        {
            content = content.Replace(oldWord, newWord);
        }

        public void AddHyphenBetweenWords()
        {
            content = content.Replace(" ", "-");
        }

        public void Display()
        {
            Console.WriteLine(content);
        }
    }

}
