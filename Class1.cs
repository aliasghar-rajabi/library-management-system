using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Library
{
    public interface FileInterface
    {
        void storeUser();
        string showUser();
        void storeBook();
        string showBook();
        string SerechUser(string value);
        string SerechBook(string value);
        string loan(string value, string id);
        string report();
    }

    public class LibraryControler : FileInterface
    {
        User user;
        Book book;
        private string[] fieldUser;
        private string[] fieldBook;
        public LibraryControler(User us,Book bk)
        {
            this.user = us;
            this.fieldUser = User.fieldUsere;
            this.book = bk;
            this.fieldBook = Book.fieldBook;
        }
        public LibraryControler()
        {
            this.fieldUser = User.fieldUsere;
            this.fieldBook = Book.fieldBook;
        }
        public string SerechUser(string value)
        {

            StreamReader Usertex = new StreamReader("C:\\c-sharp\\User.txt");
            int line = 0;
            bool sw = false;
            while (Usertex.Peek() > -1)
            {
                string text = Usertex.ReadLine();
                string[] words = text.Split('|');
                string v = words[0];
                if (v == value)
                {
                    sw = true;
                    break;
                }
                line++;
            }
            string string1;
            if (sw)
            {
                string data = File.ReadLines("C:\\c-sharp\\User.txt").ElementAt(line);
                string1 = data + "\n\n";
            }
            else
            {
                return "not found";
            }
            Usertex.Close();
            Usertex.Dispose();
            return string1;
        }

        public string loan(string value, string id)
        {
            StreamReader Booktex = new StreamReader("C:\\c-sharp\\Book.txt");
            int line = 0;
            bool sw = false;
            string w = "";
            while (Booktex.Peek() > -1)
            {
                
                string text = Booktex.ReadLine();
                string[] words = text.Split('|');
                string v = words[0];
                if (v == value)
                {
                    sw = true;
                    w = words[5];
                    break;
                }
                line++;
            }
            
            string string2 = string.Empty;
            string string1;
            string data = "";
            if (sw && w == "1")
            {
                StreamWriter reporttex = new StreamWriter("C:\\c-sharp\\report.txt", append: true);
                data = File.ReadLines("C:\\c-sharp\\Book.txt").ElementAt(line);
                string1 = data + "\n\n The book was borrowed " + "\n\n";
                reporttex.Write(data + " by user : " + id);
                reporttex.WriteLine();
                reporttex.Close();
                reporttex.Dispose();
                Booktex.Close();
                Booktex.Dispose();

            }
            else if (sw && w == "0")
            {
                Booktex.Close();
                Booktex.Dispose();
                return "The book has been borrowed";


            }
            else
            {
                Booktex.Close();
                Booktex.Dispose();
                return "not found";

            }
           /* string MyString = string.Empty;
            int line2 = 0;
            StreamWriter Booktex2 = new StreamWriter("C:\\c-sharp\\Book.txt", append: true);
            while (Booktex.Peek() > -1)
            {

                string text = Booktex.ReadLine();
                string[] words = text.Split('|');
                string v = words[0];
                if (v == value)
                {
                    MyString = words[0] + words[1] + words[2] + words[3] + words[4] + "|0";
                    Booktex2.Write(MyString);
                    break;
                }
                line2++;
            }
            Booktex2.WriteLine();
            Booktex2.Close();
            Booktex2.Dispose();*/
            return string1;
        }
        public string report()
        {
            int counter = 1;
            StreamReader reporttex = new StreamReader("C:\\c-sharp\\report.txt");
            int line = 0;
            string report = "";
            while (reporttex.Peek() > -1)
            {
                reporttex.ReadLine();
                string data = File.ReadLines("C:\\c-sharp\\report.txt").ElementAt(line);
                report += counter + " is :\n" + data + "\n\n";
                counter++;
                line++;
            }
            reporttex.Close();
            reporttex.Dispose();
            return report;
        }
        public string SerechBook(string value)
        {
            StreamReader Booktex = new StreamReader("C:\\c-sharp\\Book.txt");
            int line = 0;
            bool sw = false;
            while (Booktex.Peek() > -1)
            {
                string text = Booktex.ReadLine();
                string[] words = text.Split('|');
                string v = words[0];
                if (v == value)
                {
                    sw = true;
                    break;
                }
                line++;
            }
            string string1;
            if (sw)
            {
                string data = File.ReadLines("C:\\c-sharp\\Book.txt").ElementAt(line);
                string1 = data + "\n\n";
            }
            else
            {
                Booktex.Close();
                Booktex.Dispose();
                return "not found";
            }
            Booktex.Close();
            Booktex.Dispose();
            return string1;
        }
        public string showUser()
        {
            int counter = 1;
            StreamReader Usertex = new StreamReader("C:\\c-sharp\\User.txt");
            int line = 0;
            string user = "";
            while (Usertex.Peek() > -1)
            {
                Usertex.ReadLine();
                string data = File.ReadLines("C:\\c-sharp\\User.txt").ElementAt(line);
                user += "User" + counter + " is :\n" + data + "\n\n";
                counter++;
                line++;
            }
            Usertex.Close();
            Usertex.Dispose();
            return user;
        }

        public void storeUser()
        {
            StreamWriter Usertex = new StreamWriter("C:\\c-sharp\\User.txt", append: true);
            foreach (string field in this.fieldUser)
            {
                try
                {
                    Usertex.Write(this.user.Tostring1(field) + "|");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Usertex.WriteLine();
            Usertex.Close();
            Usertex.Dispose();
            Console.WriteLine("User information inserd");
        }
        public string showBook()
        {
            int counter = 1;
            StreamReader Booktex = new StreamReader("C:\\c-sharp\\Book.txt");
            int line = 0;
            string Book = "";
            while (Booktex.Peek() > -1)
            {
                Booktex.ReadLine();
                string data = File.ReadLines("C:\\c-sharp\\Book.txt").ElementAt(line);
                Book += "Book" + counter + " is :\n" + data + "\n\n";
                counter++;
                line++;
            }
            Booktex.Close();
            Booktex.Dispose();
            return Book;
        }

        public void storeBook()
        {

            StreamWriter Booktex = new StreamWriter("C:\\c-sharp\\Book.txt", append: true);
            foreach (string field in this.fieldBook)
            {
                try
                {
                    Booktex.Write(this.book.Tostring2(field) + "|");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Booktex.WriteLine();
            Booktex.Close();
            Booktex.Dispose();
            Console.WriteLine("Book information inserd");
        }
    }
    public class User
    {
        private string name;
        private string family;
        private string id;
        private string phone;
        public static string[] fieldUsere = { "id", "name", "family", "phone" };
        public User(string name, string family, string id, string phone)
        {
            Name = name;
            Family = family;
            Id = id;
            Phone = phone;

        }
        public string Tostring1(string field)
        {
            switch (field)
            {
                case "name":
                    return this.Name;
                case "family":
                    return this.Family;
                case "id":
                    return this.Id;
                case "phone":
                    return this.Phone;
                default:
                    return this.Name;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Family
        {
            get
            {
                return this.family;
            }
            set
            {
                this.family = value;
            }
        }
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }
    }
    public class Book
    {
        private string name;
        private string title;
        private string barcode;
        private string publisherName;
        private string releaseDate;
        private string flag;
        public static string[] fieldBook = { "barcode", "name", "title", "publisherName", "releaseDate", "flag" };
        public Book(string name, string title, string barcode, string publisherName, string releaseDate, string flag)
        {
            Name = name;
            Title = title;
            Barcode = barcode;
            PublisherName = publisherName;
            ReleaseDate = releaseDate;
            Flag = flag;

        }
        public string Tostring2(string field)
        {
            switch (field)
            {
                case "name":
                    return this.Name;
                case "title":
                    return this.Title;
                case "barcode":
                    return this.Barcode;
                case "publisherName":
                    return this.PublisherName;
                case "releaseDate":
                    return this.ReleaseDate;
                case "flag":
                    return this.Flag;
                default:
                    return this.Name;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }
        public string Barcode
        {
            get
            {
                return this.barcode;
            }
            set
            {
                this.barcode = value;
            }
        }
        public string PublisherName
        {
            get
            {
                return this.publisherName;
            }
            set
            {
                this.publisherName = value;
            }
        }
        public string ReleaseDate
        {
            get
            {
                return this.releaseDate;
            }
            set
            {
                this.releaseDate = value;
            }
        }
         public string Flag
        {
            get
            {
                return this.flag;
            }
            set
            {
                this.flag = value;
            }
        }
    }
     
    public class FileImplamentaion
    {
        private FileInterface metod;
        public FileImplamentaion(FileInterface myMetod)
        {
            this.metod = myMetod;
        }
        public void storeUser()
        {
            this.metod.storeUser();
        }
        public void storeBook()
        {
            this.metod.storeBook();
        }
        public string showUser()
        {
            return this.metod.showUser();
        }
        public string showBook()
        {
            return this.metod.showBook();
        }
        public string SerechUser(string value)
        {
            return this.metod.SerechUser(value);
        }
        public string SerechBook(string value)
        {
            return this.metod.SerechBook(value);
        }
        public string loan(string value, string id)
        {
            return this.metod.loan(value,id);
        }
        public  string report()
        {
            return this.metod.report();
        }

    }
}
