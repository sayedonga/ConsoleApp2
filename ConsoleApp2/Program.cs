using ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        TextEditor textEditor = new TextEditor();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add new document");
            Console.WriteLine("2. Remove document");
            Console.WriteLine("3. Edit document");
            Console.WriteLine("4. Count words");
            Console.WriteLine("5. Count characters");
            Console.WriteLine("6. Remove a specific word/char");
            Console.WriteLine("7. Change specific word");
            Console.WriteLine("8. Clear the document");
            Console.WriteLine("9. Add '-' between words");
            Console.WriteLine("10. Display document");
            Console.WriteLine("11. Exit");

            Console.Write("Enter your choice: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter text to add: ");
                        string textToAdd = Console.ReadLine();
                        textEditor.AddDocument(textToAdd);
                        break;
                    case 2:
                        textEditor.RemoveDocument();
                        break;
                    case 3:
                        Console.Write("Enter new text: ");
                        string newText = Console.ReadLine();
                        textEditor.EditDocument(newText);
                        break;
                    case 4:
                        textEditor.CountWords();
                        break;
                    case 5:
                        textEditor.CountChars();
                        break;
                    case 6:
                        Console.Write("Enter word/char to remove: ");
                        string wordToRemove = Console.ReadLine();
                        textEditor.RemoveWord(wordToRemove);
                        break;
                    case 7:
                        Console.Write("Enter word to replace: ");
                        string oldWord = Console.ReadLine();
                        Console.Write("Enter new word: ");
                        string newWord = Console.ReadLine();
                        textEditor.ReplaceWord(oldWord, newWord);
                        break;
                    case 8:
                        textEditor.ClearDocument();
                        break;
                    case 9:
                        textEditor.AddHyphenBetweenWords();
                        break;
                    case 10:
                        textEditor.DisplayDocument();
                        break;
                    case 11:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Text editor closed.");
    }
}
