using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();


        static Repository() {
            
            // Books
            // Book no 1
            Book myBook = new Book();
            myBook.Title = "A Hard Day's Write: The Stories Behind Every Beatles Song ";
            myBook.Author = "Steve Turner";
            myBook.Price = 150.00M;
            myBook.Publisher = "It Books";
            myBook.Published = 2005;
            myBook.ISBN = "978-0060844097";
            myBook.ImageUrl = "A_Hard_Days_Write.jpg";
            Products.Add(myBook);

            // Book no 2
            Book myBook2 = new Book("Georg Martin", "With a Little Help from My Friends: The Making of Sgt. Pepper", 180.00M, 1995);
            myBook2.Publisher = "Little Brown & Co";
            myBook2.ISBN = "0316547832";
            myBook2.ImageUrl = "The Making of Sgt. Pepper.jpg";
            Products.Add(myBook2);


            // CDs
            // CD no 1
            MusicCD myCD = new MusicCD();
        myCD.Title = "Abbey Road (Remastered)";
            myCD.Artist = "Beatles";
            myCD.Price = 128.00M;
            myCD.Released = 2009;
            myCD.Label = "EMI";
            myCD.ImageUrl = "abbey_road.jpg";
            myCD.AddTrack(new Track("Come Together", new TimeSpan(0, 4, 20), "Lennon, McCartney"));
            myCD.AddTrack(new Track("Something", new TimeSpan(0, 3, 03), "Harrison"));
            myCD.AddTrack(new Track("Maxwell's Silver Hammer", new TimeSpan(0, 3, 29), "Lennon, McCartney"));
            myCD.AddTrack(new Track("Oh! Darling", new TimeSpan(0, 3, 26), "Lennon, McCartney"));
            myCD.AddTrack(new Track("Octopus's Garden", new TimeSpan(0, 2, 51), "Starkey"));
            myCD.AddTrack(new Track("I Want You (She's So Heavy)", new TimeSpan(0, 7, 47), "Lennon, McCartney"));
            myCD.AddTrack(new Track("Here Comes The Sun", new TimeSpan(0, 3, 05), "Harrison"));
            myCD.AddTrack(new Track("Because", new TimeSpan(0, 2, 45), "Lennon, McCartney"));
            myCD.AddTrack(new Track("You Never Give Me Your Money", new TimeSpan(0, 4, 02), "Lennon, McCartney"));
            myCD.AddTrack(new Track("Sun King", new TimeSpan(0, 2, 26), "Lennon, McCartney"));
            myCD.AddTrack(new Track("Mean Mr. Mustard", new TimeSpan(0, 1, 6), "Lennon, McCartney"));
            myCD.AddTrack(new Track("Polythene Pam", new TimeSpan(0, 1, 12), "Lennon, McCartney"));
            myCD.AddTrack(new Track("She Came In Through The Bathroom Window", new TimeSpan(0, 1, 57), "Lennon, McCartney"));
            myCD.AddTrack(new Track("Golden Slumbers", new TimeSpan(0, 1, 31), "Lennon, McCartney"));
            myCD.AddTrack(new Track("Carry That Weight", new TimeSpan(0, 1, 36), "Lennon, McCartney"));
            myCD.AddTrack(new Track("The End", new TimeSpan(0, 2, 19), "Lennon, McCartney"));
            myCD.AddTrack(new Track("Her Majesty", new TimeSpan(0, 0, 23), "Lennon, McCartney"));
            Products.Add(myCD);

            // CD no 2
            MusicCD myCD2 = new MusicCD("The Beatles", "Revolver (Remastered)", 128.00M, 2009);
        myCD2.Label = "EMI";
            myCD2.ImageUrl = "revolver.jpg";

            Track track01 = new Track("Taxman", new TimeSpan(0, 2, 28));
        track01.Composer = "Harrison";
            myCD2.AddTrack(track01);

            Track track02 = new Track("Eleanor Rigby", new TimeSpan(0, 2, 6), "Lennon, McCartney");
        track02.Composer = "Lennon, McCartney";
            myCD2.AddTrack(track02);

            Track track03 = new Track("I'm Only Sleeping", new TimeSpan(0, 3, 0), "Lennon, McCartney");
        track03.Composer = "Lennon, McCartney";
            myCD2.AddTrack(track03);

            Track track04 = new Track("Love You To", new TimeSpan(0, 2, 59));
        track04.Composer = "Harrison";
            myCD2.AddTrack(track04);

            Track track05 = new Track("Here, There And Everywhere", new TimeSpan(0, 2, 23));
        track05.Composer = "Harrison";
            myCD2.AddTrack(track05);


            Track track06 = new Track("Yellow Submarine", new TimeSpan(0, 2, 38));
        track06.Composer = "Lennon, McCartney";
            myCD2.AddTrack(track06);

            Track track07 = new Track("She Said She Said", new TimeSpan(0, 2, 36));
        track07.Composer = "Lennon, McCartney";
            myCD2.AddTrack(track07);

            Track track08 = new Track("Good Day Sunshine", new TimeSpan(0, 2, 9));
        track08.Composer = "Lennon, McCartney";
            myCD2.AddTrack(track08);

            Track track09 = new Track("And Your Bird Can Sing", new TimeSpan(0, 2, 0));
        track09.Composer = "Lennon, McCartney";
            myCD2.AddTrack(track09);

            Track track10 = new Track("For No One", new TimeSpan(0, 1, 59));
        track10.Composer = "Lennon, McCartney";
            myCD2.AddTrack(track10);

            Track track11 = new Track("Doctor Robert", new TimeSpan(0, 1, 14));
        track11.Composer = "Lennon, McCartney";
            myCD2.AddTrack(track11);

            Track track12 = new Track("I Want To Tell You", new TimeSpan(0, 2, 27));
        track12.Composer = "Harrison";
            myCD2.AddTrack(track12);

            Track track13 = new Track("Got To Get You Into My Life", new TimeSpan(0, 2, 29));
        track13.Composer = "Lennon, McCartney";
            myCD2.AddTrack(track13);

            Track track14 = new Track("Tomorrow Newer Knows", new TimeSpan(0, 3, 01));
        track14.Composer = "Lennon, McCartney";
            myCD2.AddTrack(track14);
            Products.Add(myCD2);


            // Movies
            // create a new Movie objects
            Movie movie1 = new Movie("Jungle Book", 160.50M, "junglebook.jpg", "Jon Favreau");
            Products.Add(movie1);

            Movie movie2 = new Movie("Gladiator", 49.95M, "gladiator.jpg", "Ridley Scott");
            Products.Add(movie2);

            Movie movie3 = new Movie("Forrest Gump", 154.50M, "forrest-gump.jpg", "Robert Zemeckis");
            Products.Add(movie3);

            Customer c1 = new Customer(1, "Tina", "Petterson", "Irisdahlsvej 32", "8200", "Århus N");
            Customer c2 = new Customer(2, "Thomas", "Larsson", "Solsikkevej 32", "8000", "Århus C");

            Invoice i1 = new Invoice(1, new DateTime(2016, 9, 12), c1);
            Invoice i2 = new Invoice(2, new DateTime(2016, 9, 24), c2);

            i1.AddOrderItem(movie3, 1);
            i1.AddOrderItem(myBook2, 1);

            i2.AddOrderItem(myBook, 1);
            i2.AddOrderItem(myCD2, 1);

            Invoices.Add(i1);
            Invoices.Add(i2);
        }

    }
}