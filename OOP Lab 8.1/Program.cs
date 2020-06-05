using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;



namespace OOP_Lab_8._1
{
    class Book
    {
        public string Name;
        public string Surname;
        public string Zavdana;
        public DateTime Date;
        public int Number;

        public Book() { }
        public Book(string name, string surname, string zavdana, DateTime date, int number)
        {
            Name = name;
            Surname = surname;
            Zavdana = zavdana;
            Date = date;
            Number = number;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Surname + " " + this.Zavdana + " " + this.Date + " " + this.Number;
        }

    }
    class Program
    {
        static public void FileInformationRewrite(string path, List<Book> users)
        {
            File.WriteAllText(path, String.Empty);
            using (StreamWriter s = new StreamWriter(path))
            {
                foreach (Book informationUnit in users)
                {
                    s.WriteLine(informationUnit.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            List<Book> A = new List<Book>();
            using (StreamReader s = new StreamReader("text.txt"))
            {
                string str;
                string[] a;
                while (s.EndOfStream == false)
                {
                    str = s.ReadLine();
                    if (str != "" && str != " ")
                    {
                        a = str.Split(" ");
                        A.Add(new Book(a[0], a[1], a[2], DateTime.Parse(a[3]), int.Parse(a[4])));
                    }
                }
            }
            Console.WriteLine("Add note: A");
            Console.WriteLine("Edit note: E");
            Console.WriteLine("Remove note: R");
            Console.WriteLine("Show notes: Enter");
            Console.WriteLine("Sort by name: N");
            Console.WriteLine("Sort by zavdana: D");
            Console.WriteLine("Sort by number: S");
            Console.WriteLine("Sort by surname: U");
            Console.WriteLine("Sort by date: G");
            Console.WriteLine("Exit: Esc");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                foreach (Book p in A)
                {
                    Console.WriteLine(p.ToString());

                }
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by zavdana: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by date: G");
                Console.WriteLine("Exit: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.A)
            {
                Console.Clear();
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("Zavdana:");
                string dis = Console.ReadLine();
                Console.WriteLine("date:");
                string s = Console.ReadLine();
                DateTime date = DateTime.Parse(s);
                
                Console.WriteLine("Number:");
                int num = int.Parse(Console.ReadLine());


                if (name != null && surname != null && dis != null && date != null && num != null)
                {
                    A.Add(new Book() { Name = name, Surname = surname, Zavdana = dis, Date = date, Number = num });
                    FileInformationRewrite("doctor.txt", A);
                }
                else
                    Console.WriteLine("You do not add a new user!");
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by zavdana: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by date: G");
                Console.WriteLine("Exit: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.R)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of file you want to delete");
                int n = int.Parse(Console.ReadLine());
                A.RemoveAt(n - 1);
                Console.WriteLine(n + " is deleted");
                FileInformationRewrite("doctor1.txt", A);
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by zavdana: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by date: G");
                Console.WriteLine("Exit: Esc");

            }

            if (Console.ReadKey().Key == ConsoleKey.E)
            {
                Console.Clear();
                Book A1 = new Book();
                Console.WriteLine("Which file you want to edit");
                int k = int.Parse(Console.ReadLine());

                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                A1.Name = name;
                Console.WriteLine("Surname:");
                string sur = Console.ReadLine();
                A1.Surname = sur;
                Console.WriteLine("Zavdana:");
                string dis = Console.ReadLine();
                A1.Zavdana = dis;
                Console.WriteLine("Date:");
                DateTime date = DateTime.Parse(Console.ReadLine());
                A1.Date = date;
                Console.WriteLine("Number:");
                int num = int.Parse(Console.ReadLine());
                A1.Number = num;

                A.RemoveAt(k - 1);
                A.Insert(k - 1, A1);
                FileInformationRewrite("text.txt", A);
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by zavdana: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by date: G");
                Console.WriteLine("Exit: Esc");
            }


            if (Console.ReadKey().Key == ConsoleKey.N)

            {

                var result = from u in A
                             orderby u.Name
                             select u;
                foreach (Book a in result)
                {
                    Console.WriteLine("\n" + a.ToString());
                }
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by zavdana: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by date: G");
                Console.WriteLine("Exit: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.D)

            {

                var result = from u in A
                             orderby u.Zavdana
                             select u;
                foreach (Book a in result)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by zavdana: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by date: G");
                Console.WriteLine("Exit: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.U)
            {

                var result = from u in A
                             orderby u.Surname
                             select u;
                foreach (Book a in result)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by zavdana: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by date: G");
                Console.WriteLine("Exit: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.G)

            {

                var result = from u in A
                             orderby u.Date
                             select u;
                foreach (Book a in result)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by zavdana: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by date: G");
                Console.WriteLine("Exit: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.S)

            {
                var result = from u in A
                             orderby u.Number
                             select u;
                foreach (Book a in result)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("Add note: A");
                Console.WriteLine("Edit note: E");
                Console.WriteLine("Remove note: R");
                Console.WriteLine("Show notes: Enter");
                Console.WriteLine("Sort by name: N");
                Console.WriteLine("Sort by zavdana: D");
                Console.WriteLine("Sort by number: S");
                Console.WriteLine("Sort by surname: U");
                Console.WriteLine("Sort by date: G");
                Console.WriteLine("Exit: Esc");
            }
            Console.ReadKey();
        }
    }
}