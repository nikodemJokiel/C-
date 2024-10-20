namespace _1_6_dziedziczenie
{
    // Klasa bazowa dla osoby
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Konstruktor inicjalizujący pola FirstName i LastName
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    // Klasa reprezentująca autora, dziedziczy po klasie Person
    public class Author : Person
    {
        public List<Book> BooksList { get; set; }

        // Konstruktor inicjalizujący pola FirstName, LastName oraz pustą listę książek
        public Author(string firstName, string lastName) : base(firstName, lastName)
        {
            BooksList = new List<Book>();
        }

        // Metoda dodająca książkę do listy książek autora
        public void AddBook(Book book)
        {
            BooksList.Add(book);
        }
    }

    // Klasa reprezentująca książkę
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int PublicationYear { get; set; }

        // Konstruktor inicjalizujący pola Title, Author oraz PublicationYear
        public Book(string title, Author author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }
    }

    // Klasa reprezentująca czytelnika, dziedziczy po klasie Person
    public class Reader : Person
    {
        public List<Book> BorrowedBooksList { get; set; }

        // Konstruktor inicjalizujący pola FirstName, LastName oraz pustą listę wypożyczeń
        public Reader(string firstName, string lastName) : base(firstName, lastName)
        {
            BorrowedBooksList = new List<Book>();
        }

        // Metoda dodająca książkę do listy wypożyczeń
        public void BorrowBook(Book book)
        {
            BorrowedBooksList.Add(book);
            Console.WriteLine($"Czytelnik {FirstName} {LastName} wypożyczył książkę: {book.Title}");
        }
    }

    // Klasa reprezentująca bibliotekę
    public class Library
    {
        public List<Book> BooksList { get; set; }
        public List<Reader> ReadersList { get; set; }
        public List<Author> AuthorsList { get; set; }

        // Konstruktor inicjalizujący pustą listę książek i czytelników
        public Library()
        {
            BooksList = new List<Book>();
            ReadersList = new List<Reader>();
            AuthorsList = new List<Author>();
        }

        // Metoda dodająca książkę do listy książek
        public void AddBook(Book book)
        {
            BooksList.Add(book);
            Console.WriteLine($"Dodano książkę: {book.Title}");
        }

        // Metoda dodająca czytelnika do listy czytelników
        public void AddReader(Reader reader)
        {
            ReadersList.Add(reader);
            Console.WriteLine($"Dodano czytelnika: {reader.FirstName} {reader.LastName}");
        }
        public void AddAuthor(Author author)
        {
            AuthorsList.Add(author);
            Console.WriteLine($"Dodano autora: {author.FirstName} {author.LastName}");
        }

        // Metoda umożliwiająca wypożyczenie książki przez czytelnika
        public void BorrowBook(Reader reader, Book book)
        {
            if (BooksList.Contains(book))
            {
                reader.BorrowBook(book);
                BooksList.Remove(book);
                Console.WriteLine($"Książka {book.Title} została wypożyczona przez {reader.FirstName} {reader.LastName}");
            }
            else
            {
                Console.WriteLine($"Książka {book.Title} nie jest dostępna w bibliotece");
            }
        }
        // Metoda wyświetlająca wszystkie książki w bibliotece
        public void DisplayBooks()
        {
            Console.WriteLine("Książki w bibliotece:");
            foreach (var book in BooksList)
            {
                Console.WriteLine($"{book.Title} - {book.Author.FirstName} {book.Author.LastName} ({book.PublicationYear})");
            }
        }

        // Metoda wyświetlająca wszystkich autorów w bibliotece
        public void DisplayAuthors()
        {
            Console.WriteLine("Autorzy w bibliotece:");
            foreach (var author in AuthorsList)
            {
                Console.WriteLine($"{author.FirstName} {author.LastName}");
            }
        }

        // Metoda wyświetlająca wszystkich autorów w formie tabeli
        public void DisplayAuthorsTable()
        {
            Console.WriteLine("Lista autorów:");
            Console.WriteLine("ID\tImię\tNazwisko");
            for (int i = 0; i < AuthorsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}\t{AuthorsList[i].FirstName}\t{AuthorsList[i].LastName}");
            }
        }

        // Metoda wyświetlająca wszystkie wypożyczone książki
        public void DisplayBorrowedBooks()
        {
            Console.WriteLine("Wypożyczone książki:");
            foreach (var reader in ReadersList)
            {
                foreach (var book in reader.BorrowedBooksList)
                {
                    Console.WriteLine($"{book.Title} - {book.Author.FirstName} {book.Author.LastName} ({book.PublicationYear}) wypożyczona przez {reader.FirstName} {reader.LastName}");
                }
            }
        }
    }

    // Przykładowe użycie
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Dodaj autora");
                Console.WriteLine("2. Dodaj książkę");
                Console.WriteLine("3. Dodaj czytelnika");
                Console.WriteLine("4. Wypożycz książkę");
                Console.WriteLine("5. Wyświetl wszystkie książki");
                Console.WriteLine("6. Wyświetl wszystkich autorów");
                Console.WriteLine("7. Wyświetl wszystkie wypożyczone książki");
                Console.WriteLine("8. Wyjście");
                Console.Write("Wybierz opcję: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Podaj imię autora: ");
                        string firstNameA = Console.ReadLine();
                        Console.Write("Podaj nazwisko autora: ");
                        string lastNameA = Console.ReadLine();
                        Author author = new Author(firstNameA, lastNameA);
                        library.AddAuthor(author);
                        break;
                    case "2":
                        library.DisplayAuthors();
                        Console.WriteLine("podaj numer autora: ");
                        int authorindex = int.Parse(Console.ReadLine()) - 1;
                        if(authorindex>=0 && authorindex < library.AuthorsList.Count)
                        {
                            Author selectedAuthor = library.AuthorsList[authorindex];
                            Console.WriteLine("Podaj tytuł książki: ");
                            string title = Console.ReadLine();
                            Console.WriteLine("Podaj rok publikacji");
                            int pubYear = int.Parse(Console.ReadLine());
                            Book book = new Book(title, selectedAuthor, pubYear);
                            library.AddBook(book);
                        }
                        
                        
                        


                        break;
                    case "3":
                        Console.Write("Podaj imię czytelnika: ");
                        string firstNameR = Console.ReadLine();
                        Console.Write("Podaj nazwisko czytelnika: ");
                        string lastNameR = Console.ReadLine();
                        Reader reader = new Reader(firstNameR, lastNameR);
                        library.AddReader(reader);
                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "6":

                        break;
                    case "7":

                        break;
                    case "8":

                        break;
                }
            }
            /*
            // Tworzenie autora
            Author author = new Author("Adam", "Mickiewicz");
            // Tworzenie książki
            Book book = new Book("Pan Tadeusz", author, 1834);
            // Dodawanie książki do listy książek autora
            author.AddBook(book);

            // Tworzenie czytelnika
            Reader reader = new Reader("Jan", "Kowalski");
            // Tworzenie biblioteki
            Library library = new Library();
            // Dodawanie książki do biblioteki
            library.AddBook(book);
            // Dodawanie czytelnika do biblioteki
            library.AddReader(reader);

            // Wypożyczanie książki przez czytelnika
            library.BorrowBook(reader, book);
            */
            Console.ReadKey();
        }
    }
}
