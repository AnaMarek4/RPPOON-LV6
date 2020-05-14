using System;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            Note noteOne = new Note("Danas je četvrtak.", "Vikend se bliži!");
            Note noteTwo = new Note("Dobro jutro!", "Laku noć!");
            Note noteThree = new Note("Valar Morghulis", "Valar Dohaeris");
            notebook.AddNote(noteOne);
            notebook.AddNote(noteTwo);
            notebook.AddNote(noteThree);

            Iterator iterator = new Iterator(notebook);
            for(int i = 0; i < notebook.Count; i++)
            {
                iterator.Current.Show();
                iterator.Next();
            }

            Box box = new Box();
            Product productOne = new Product("Šišanje", 80);
            Product productTwo = new Product("Frizura", 120);
            Product productThree = new Product("Pranje kose", 20);
            box.AddProduct(productOne);
            box.AddProduct(productTwo);
            box.AddProduct(productThree);

            BoxIterator boxIterator = new BoxIterator(box);
            for (int i = 0; i < box.Count; i++)
            {
                boxIterator.Current.Show();
                boxIterator.Next();
            }

            BankAccountCareTaker bankAccountCareTaker = new BankAccountCareTaker();
            BankAccount bankAccount = new BankAccount("Ana", "Virovitica", 1000);
            BankAccountMemento memento = new BankAccountMemento(bankAccount);
            bankAccountCareTaker.PreviousState = memento;
            Console.WriteLine(bankAccountCareTaker.PreviousState.Balance.ToString() + "HRK");
            bankAccount.UpdateBalance(250);
            memento.AddPreviousState(bankAccount);
            bankAccountCareTaker.PreviousState = memento;
            Console.WriteLine(bankAccountCareTaker.PreviousState.Balance.ToString() + "HRK" + "\n");

            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");
            logger.Log("Covid-19", MessageType.INFO);
            fileLogger.Log("Dezinfekcija", MessageType.WARNING);
            fileLogger.Log("Virus", MessageType.ERROR);

            string s = "53h&eds";
            StringChecker digitChecker = new StringDigitChecker();
            StringChecker upperCaseChecker = new StringUpperCaseChecker();
            StringChecker lowerCaseChecker = new StringLowerCaseChecker();
            Console.WriteLine("Contains digit: " + digitChecker.Check(s));
            Console.WriteLine("Contains upper letter: " + upperCaseChecker.Check(s));
            Console.WriteLine("Contains lower letter: " + lowerCaseChecker.Check(s));
        }
    }
}