using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.AddNote(new Note("rppoon", "Luka Vukadin"));
            notebook.AddNote(new Note("rppoon", "Tekst"));
            notebook.AddNote(new Note("Naslov", "bok"));

            Iterator iterator = new Iterator(notebook);
            iterator.Current.Show();
            iterator.Next().Show();

            while (iterator.IsDone != true)
            {
                iterator.Current.Show();
                iterator.Next();
            }
        }
    }
}
