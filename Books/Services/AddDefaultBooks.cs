using System.Collections.Generic;
using Books.Models;

namespace Books.Services
{
    public class AddDefaultBooks
    {
        public List<Models.Books> AddBooks()
        {
            var books = new List<Models.Books>
            {
                new Models.Books()
                {
                    BookId = 1,
                    BookName = "Книга 1",
                    Author = "Автор 1",
                    PageCount = 50,
                    PublishingYear = 1980,
                    EditionNumber = 1,
                    BookPrintNumber = 101,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 51,
                    BooksCountInParty = 50000,
                    PrintingFactoryName = "Книгопечатный завод 1"
                },
                new Models.Books()
                {
                    BookId = 2,
                    BookName = "Книга 2",
                    Author = "Автор 2",
                    PageCount = 150,
                    PublishingYear = 1981,
                    EditionNumber = 3,
                    BookPrintNumber = 987,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 6,
                    BooksCountInParty = 4000,
                    PrintingFactoryName = "Книгопечатный завод 2"
                },
                new Models.Books()
                {
                    BookId = 3,
                    BookName = "Книга 3",
                    Author = "Автор 3",
                    PageCount = 100,
                    PublishingYear = 1982,
                    EditionNumber = 5,
                    BookPrintNumber = 124,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 30,
                    BooksCountInParty = 3000,
                    PrintingFactoryName = "Книгопечатный завод 3"
                },
                new Models.Books()
                {
                    BookId = 4,
                    BookName = "Книга 4",
                    Author = "Автор 4",
                    PageCount = 200,
                    PublishingYear = 1983,
                    EditionNumber = 7,
                    BookPrintNumber = 965,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 30,
                    BooksCountInParty = 100,
                    PrintingFactoryName = "Книгопечатный завод 4"
                },
                new Models.Books()
                {
                    BookId = 5,
                    BookName = "Книга 5",
                    Author = "Автор 5",
                    PageCount = 100,
                    PublishingYear = 1984,
                    EditionNumber = 9,
                    BookPrintNumber = 155,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 12,
                    BooksCountInParty = 25040,
                    PrintingFactoryName = "Книгопечатный завод 5"
                },
                new Models.Books()
                {
                    BookId = 6,
                    BookName = "Книга А",
                    Author = "Автор А",
                    PageCount = 200,
                    PublishingYear = 1985,
                    EditionNumber = 11,
                    BookPrintNumber = 954,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 15,
                    BooksCountInParty = 25080,
                    PrintingFactoryName = "Книгопечатный завод А"
                },
                new Models.Books()
                {
                    BookId = 7,
                    BookName = "Книга Б",
                    Author = "Автор Б",
                    PageCount = 150,
                    PublishingYear = 1986,
                    EditionNumber = 13,
                    BookPrintNumber = 166,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 17,
                    BooksCountInParty = 25990,
                    PrintingFactoryName = "Книгопечатный завод Б"
                },
                new Models.Books()
                {
                    BookId = 8,
                    BookName = "Книга В",
                    Author = "Автор В",
                    PageCount = 250,
                    PublishingYear = 1987,
                    EditionNumber = 15,
                    BookPrintNumber = 943,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 1,
                    BooksCountInParty = 18800,
                    PrintingFactoryName = "Книгопечатный завод В"
                },
                new Models.Books()
                {
                    BookId = 9,
                    BookName = "Книга Г",
                    Author = "Автор Г",
                    PageCount = 150,
                    PublishingYear = 1988,
                    EditionNumber = 17,
                    BookPrintNumber = 167,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 19,
                    BooksCountInParty = 27700,
                    PrintingFactoryName = "Книгопечатный завод Г"
                },
                new Models.Books()
                {
                    BookId = 10,
                    BookName = "Книга Д",
                    Author = "Автор Д",
                    PageCount = 250,
                    PublishingYear = 1989,
                    EditionNumber = 19,
                    BookPrintNumber = 932,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 21,
                    BooksCountInParty = 26600,
                    PrintingFactoryName = "Книгопечатный завод Д"
                },
                new Models.Books()
                {
                    BookId = 11,
                    BookName = "Книга Е",
                    Author = "Автор Е",
                    PageCount = 200,
                    PublishingYear = 2000,
                    EditionNumber = 21,
                    BookPrintNumber = 178,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 12,
                    BooksCountInParty = 23300,
                    PrintingFactoryName = "Книгопечатный завод Е"
                },
                new Models.Books()
                {
                    BookId = 12,
                    BookName = "Книга Ё",
                    Author = "Автор Ё",
                    PageCount = 300,
                    PublishingYear = 2001,
                    EditionNumber = 23,
                    BookPrintNumber = 452,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 13,
                    BooksCountInParty = 222500,
                    PrintingFactoryName = "Книгопечатный завод Ё"
                },
                new Models.Books()
                {
                    BookId = 13,
                    BookName = "Книга Ж",
                    Author = "Автор Ж",
                    PageCount = 200,
                    PublishingYear = 2002,
                    EditionNumber = 25,
                    BookPrintNumber = 357,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 41,
                    BooksCountInParty = 62500,
                    PrintingFactoryName = "Книгопечатный завод Ж"
                },
                new Models.Books()
                {
                    BookId = 14,
                    BookName = "Книга З",
                    Author = "Автор З",
                    PageCount = 300,
                    PublishingYear = 2003,
                    EditionNumber = 27,
                    BookPrintNumber = 854,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 91,
                    BooksCountInParty = 2500,
                    PrintingFactoryName = "Книгопечатный завод З"
                },
                new Models.Books()
                {
                    BookId = 15,
                    BookName = "Книга И",
                    Author = "Автор И",
                    PageCount = 250,
                    PublishingYear = 2004,
                    EditionNumber = 29,
                    BookPrintNumber = 159,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 81,
                    BooksCountInParty = 1500,
                    PrintingFactoryName = "Книгопечатный завод И"
                },
                new Models.Books()
                {
                    BookId = 16,
                    BookName = "Книга Й",
                    Author = "Автор Й",
                    PageCount = 350,
                    PublishingYear = 2005,
                    EditionNumber = 31,
                    BookPrintNumber = 753,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 53,
                    BooksCountInParty = 12500,
                    PrintingFactoryName = "Книгопечатный завод Й"
                },
                new Models.Books()
                {
                    BookId = 17,
                    BookName = "Книга К",
                    Author = "Автор К",
                    PageCount = 250,
                    PublishingYear = 2006,
                    EditionNumber = 33,
                    BookPrintNumber = 35,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 16,
                    BooksCountInParty = 142500,
                    PrintingFactoryName = "Книгопечатный завод К"
                },
                new Models.Books()
                {
                    BookId = 18,
                    BookName = "Книга Л",
                    Author = "Автор Л",
                    PageCount = 350,
                    PublishingYear = 2007,
                    EditionNumber = 35,
                    BookPrintNumber = 258,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 1,
                    BooksCountInParty = 122500,
                    PrintingFactoryName = "Книгопечатный завод Л"
                },
                new Models.Books()
                {
                    BookId = 19,
                    BookName = "Книга М",
                    Author = "Автор М",
                    PageCount = 300,
                    PublishingYear = 2008,
                    EditionNumber = 2,
                    BookPrintNumber = 425,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 18,
                    BooksCountInParty = 442500,
                    PrintingFactoryName = "Книгопечатный завод М"
                },
                new Models.Books()
                {
                    BookId = 20,
                    BookName = "Книга Н",
                    Author = "Автор Н",
                    PageCount = 400,
                    PublishingYear = 2009,
                    EditionNumber = 4,
                    BookPrintNumber = 542,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 21,
                    BooksCountInParty = 522500,
                    PrintingFactoryName = "Книгопечатный завод Н"
                },
                new Models.Books()
                {
                    BookId = 21,
                    BookName = "Книга О",
                    Author = "Автор О",
                    PageCount = 300,
                    PublishingYear = 1990,
                    EditionNumber = 6,
                    BookPrintNumber = 843,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 1,
                    BooksCountInParty = 252500,
                    PrintingFactoryName = "Книгопечатный завод О"
                },
                new Models.Books()
                {
                    BookId = 22,
                    BookName = "Книга П",
                    Author = "Автор П",
                    PageCount = 400,
                    PublishingYear = 1991,
                    EditionNumber = 8,
                    BookPrintNumber = 674,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 11,
                    BooksCountInParty = 91460,
                    PrintingFactoryName = "Книгопечатный завод П"
                },
                new Models.Books()
                {
                    BookId = 23,
                    BookName = "Книга Р",
                    Author = "Автор Р",
                    PageCount = 350,
                    PublishingYear = 1992,
                    EditionNumber = 10,
                    BookPrintNumber = 197,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 19,
                    BooksCountInParty = 326500,
                    PrintingFactoryName = "Книгопечатный завод Р"
                },
                new Models.Books()
                {
                    BookId = 24,
                    BookName = "Книга С",
                    Author = "Автор С",
                    PageCount = 450,
                    PublishingYear = 1993,
                    EditionNumber = 12,
                    BookPrintNumber = 348,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 18,
                    BooksCountInParty = 28500,
                    PrintingFactoryName = "Книгопечатный завод С"
                },
                new Models.Books()
                {
                    BookId = 25,
                    BookName = "Книга Т",
                    Author = "Автор Т",
                    PageCount = 350,
                    PublishingYear = 1994,
                    EditionNumber = 14,
                    BookPrintNumber = 485,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 1,
                    BooksCountInParty = 92500,
                    PrintingFactoryName = "Книгопечатный завод Т"
                },
                new Models.Books()
                {
                    BookId = 26,
                    BookName = "Книга У",
                    Author = "Автор У",
                    PageCount = 450,
                    PublishingYear = 1995,
                    EditionNumber = 16,
                    BookPrintNumber = 125,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 17,
                    BooksCountInParty = 50500,
                    PrintingFactoryName = "Книгопечатный завод У"
                },
                new Models.Books()
                {
                    BookId = 27,
                    BookName = "Книга Ф",
                    Author = "Автор Ф",
                    PageCount = 400,
                    PublishingYear = 1996,
                    EditionNumber = 18,
                    BookPrintNumber = 475,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 165,
                    BooksCountInParty = 502500,
                    PrintingFactoryName = "Книгопечатный завод Ф"
                },
                new Models.Books()
                {
                    BookId = 28,
                    BookName = "Книга Х",
                    Author = "Автор Х",
                    PageCount = 500,
                    PublishingYear = 1997,
                    EditionNumber = 20,
                    BookPrintNumber = 666,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 451,
                    BooksCountInParty = 442500,
                    PrintingFactoryName = "Книгопечатный завод Х"
                },
                new Models.Books()
                {
                    BookId = 29,
                    BookName = "Книга Ц",
                    Author = "Автор Ц",
                    PageCount = 400,
                    PublishingYear = 1998,
                    EditionNumber = 22,
                    BookPrintNumber = 777,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 461,
                    BooksCountInParty = 255500,
                    PrintingFactoryName = "Книгопечатный завод Ц"
                },
                new Models.Books()
                {
                    BookId = 30,
                    BookName = "Книга Ч",
                    Author = "Автор Ч",
                    PageCount = 500,
                    PublishingYear = 1999,
                    EditionNumber = 24,
                    BookPrintNumber = 888,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 51,
                    BooksCountInParty = 250000,
                    PrintingFactoryName = "Книгопечатный завод Ч"
                },
                new Models.Books()
                {
                    BookId = 31,
                    BookName = "Книга Ш",
                    Author = "Автор Ш",
                    PageCount = 450,
                    PublishingYear = 2010,
                    EditionNumber = 26,
                    BookPrintNumber = 111,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 166,
                    BooksCountInParty = 250000,
                    PrintingFactoryName = "Книгопечатный завод Ш"
                },
                new Models.Books()
                {
                    BookId = 32,
                    BookName = "Книга Щ",
                    Author = "Автор Щ",
                    PageCount = 550,
                    PublishingYear = 2011,
                    EditionNumber = 28,
                    BookPrintNumber = 142,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 185,
                    BooksCountInParty = 42500,
                    PrintingFactoryName = "Книгопечатный завод Щ"
                },
                new Models.Books()
                {
                    BookId = 33,
                    BookName = "Книга Ъ",
                    Author = "Автор Ъ",
                    PageCount = 450,
                    PublishingYear = 2012,
                    EditionNumber = 30,
                    BookPrintNumber = 335,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 513,
                    BooksCountInParty = 9500,
                    PrintingFactoryName = "Книгопечатный завод Ъ"
                },
                new Models.Books()
                {
                    BookId = 34,
                    BookName = "Книга Ы",
                    Author = "Автор Ы",
                    PageCount = 550,
                    PublishingYear = 2013,
                    EditionNumber = 32,
                    BookPrintNumber = 224,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 436,
                    BooksCountInParty = 8500,
                    PrintingFactoryName = "Книгопечатный завод Ы"
                },
                new Models.Books()
                {
                    BookId = 35,
                    BookName = "Книга Ь",
                    Author = "Автор Ь",
                    PageCount = 500,
                    PublishingYear = 2014,
                    EditionNumber = 34,
                    BookPrintNumber = 214,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 25,
                    BooksCountInParty = 5500,
                    PrintingFactoryName = "Книгопечатный завод Ь"
                },
                new Models.Books()
                {
                    BookId = 36,
                    BookName = "Книга Э",
                    Author = "Автор Э",
                    PageCount = 600,
                    PublishingYear = 2015,
                    EditionNumber = 36,
                    BookPrintNumber = 216,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 40,
                    BooksCountInParty = 3500,
                    PrintingFactoryName = "Книгопечатный завод Э"
                },
                new Models.Books()
                {
                    BookId = 37,
                    BookName = "Книга Ю",
                    Author = "Автор Ю",
                    PageCount = 500,
                    PublishingYear = 2016,
                    EditionNumber = 38,
                    BookPrintNumber = 244,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 444,
                    BooksCountInParty = 2500,
                    PrintingFactoryName = "Книгопечатный завод Ю"
                },
                new Models.Books()
                {
                    BookId = 38,
                    BookName = "Книга Я",
                    Author = "Автор Я",
                    PageCount = 600,
                    PublishingYear = 2017,
                    EditionNumber = 37,
                    BookPrintNumber = 554,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 25,
                    BooksCountInParty = 25000,
                    PrintingFactoryName = "Книгопечатный завод Я"
                },
                new Models.Books()
                {
                    BookId = 39,
                    BookName = "Книга А1",
                    Author = "Автор А1",
                    PageCount = 200,
                    PublishingYear = 1985,
                    EditionNumber = 11,
                    BookPrintNumber = 954,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 15,
                    BooksCountInParty = 25080,
                    PrintingFactoryName = "Книгопечатный завод А1"
                },
                new Models.Books()
                {
                    BookId = 40,
                    BookName = "Книга Б2",
                    Author = "Автор Б2",
                    PageCount = 150,
                    PublishingYear = 1986,
                    EditionNumber = 13,
                    BookPrintNumber = 166,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 17,
                    BooksCountInParty = 25990,
                    PrintingFactoryName = "Книгопечатный завод Б2"
                },
                new Models.Books()
                {
                    BookId = 41,
                    BookName = "Книга В3",
                    Author = "Автор В3",
                    PageCount = 250,
                    PublishingYear = 1987,
                    EditionNumber = 15,
                    BookPrintNumber = 943,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 1,
                    BooksCountInParty = 18800,
                    PrintingFactoryName = "Книгопечатный завод В3"
                },
                new Models.Books()
                {
                    BookId = 42,
                    BookName = "Книга Г4",
                    Author = "Автор Г4",
                    PageCount = 150,
                    PublishingYear = 1988,
                    EditionNumber = 17,
                    BookPrintNumber = 167,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 19,
                    BooksCountInParty = 27700,
                    PrintingFactoryName = "Книгопечатный завод Г4"
                },
                new Models.Books()
                {
                    BookId = 43,
                    BookName = "Книга Д5",
                    Author = "Автор Д5",
                    PageCount = 250,
                    PublishingYear = 1989,
                    EditionNumber = 19,
                    BookPrintNumber = 932,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 21,
                    BooksCountInParty = 26600,
                    PrintingFactoryName = "Книгопечатный завод Д5"
                },
                new Models.Books()
                {
                    BookId = 44,
                    BookName = "Книга Е6",
                    Author = "Автор Е6",
                    PageCount = 200,
                    PublishingYear = 2000,
                    EditionNumber = 21,
                    BookPrintNumber = 178,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 12,
                    BooksCountInParty = 23300,
                    PrintingFactoryName = "Книгопечатный завод Е6"
                },
                new Models.Books()
                {
                    BookId = 45,
                    BookName = "Книга Ё7",
                    Author = "Автор Ё7",
                    PageCount = 300,
                    PublishingYear = 2001,
                    EditionNumber = 23,
                    BookPrintNumber = 452,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 13,
                    BooksCountInParty = 222500,
                    PrintingFactoryName = "Книгопечатный завод Ё7"
                },
                new Models.Books()
                {
                    BookId = 46,
                    BookName = "Книга Ж8",
                    Author = "Автор Ж8",
                    PageCount = 200,
                    PublishingYear = 2002,
                    EditionNumber = 25,
                    BookPrintNumber = 357,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 41,
                    BooksCountInParty = 62500,
                    PrintingFactoryName = "Книгопечатный завод Ж8"
                },
                new Models.Books()
                {
                    BookId = 47,
                    BookName = "Книга З9",
                    Author = "Автор З9",
                    PageCount = 300,
                    PublishingYear = 2003,
                    EditionNumber = 27,
                    BookPrintNumber = 854,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 91,
                    BooksCountInParty = 2500,
                    PrintingFactoryName = "Книгопечатный завод З9"
                },
                new Models.Books()
                {
                    BookId = 48,
                    BookName = "Книга И0",
                    Author = "Автор И0",
                    PageCount = 250,
                    PublishingYear = 2004,
                    EditionNumber = 29,
                    BookPrintNumber = 159,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 81,
                    BooksCountInParty = 1500,
                    PrintingFactoryName = "Книгопечатный завод И0"
                },
                new Models.Books()
                {
                    BookId = 49,
                    BookName = "Книга Й1",
                    Author = "Автор Й1",
                    PageCount = 350,
                    PublishingYear = 2005,
                    EditionNumber = 31,
                    BookPrintNumber = 753,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 53,
                    BooksCountInParty = 12500,
                    PrintingFactoryName = "Книгопечатный завод Й1"
                },
                new Models.Books()
                {
                    BookId = 50,
                    BookName = "Книга К2",
                    Author = "Автор К2",
                    PageCount = 250,
                    PublishingYear = 2006,
                    EditionNumber = 33,
                    BookPrintNumber = 35,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 16,
                    BooksCountInParty = 142500,
                    PrintingFactoryName = "Книгопечатный завод К2"
                },
                new Models.Books()
                {
                    BookId = 51,
                    BookName = "Книга Л3",
                    Author = "Автор Л3",
                    PageCount = 350,
                    PublishingYear = 2007,
                    EditionNumber = 35,
                    BookPrintNumber = 258,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 1,
                    BooksCountInParty = 122500,
                    PrintingFactoryName = "Книгопечатный завод Л3"
                },
                new Models.Books()
                {
                    BookId = 52,
                    BookName = "Книга М4",
                    Author = "Автор М4",
                    PageCount = 300,
                    PublishingYear = 2008,
                    EditionNumber = 2,
                    BookPrintNumber = 425,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 18,
                    BooksCountInParty = 442500,
                    PrintingFactoryName = "Книгопечатный завод М4"
                },
                new Models.Books()
                {
                    BookId = 53,
                    BookName = "Книга Н5",
                    Author = "Автор Н5",
                    PageCount = 400,
                    PublishingYear = 2009,
                    EditionNumber = 4,
                    BookPrintNumber = 542,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 21,
                    BooksCountInParty = 522500,
                    PrintingFactoryName = "Книгопечатный завод Н5"
                },
                new Models.Books()
                {
                    BookId = 54,
                    BookName = "Книга О6",
                    Author = "Автор О6",
                    PageCount = 300,
                    PublishingYear = 1990,
                    EditionNumber = 6,
                    BookPrintNumber = 843,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 1,
                    BooksCountInParty = 252500,
                    PrintingFactoryName = "Книгопечатный завод О6"
                },
                new Models.Books()
                {
                    BookId = 55,
                    BookName = "Книга П7",
                    Author = "Автор П7",
                    PageCount = 400,
                    PublishingYear = 1991,
                    EditionNumber = 8,
                    BookPrintNumber = 674,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 11,
                    BooksCountInParty = 91460,
                    PrintingFactoryName = "Книгопечатный завод П7"
                },
                new Models.Books()
                {
                    BookId = 56,
                    BookName = "Книга Р8",
                    Author = "Автор Р8",
                    PageCount = 350,
                    PublishingYear = 1992,
                    EditionNumber = 10,
                    BookPrintNumber = 197,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 19,
                    BooksCountInParty = 326500,
                    PrintingFactoryName = "Книгопечатный завод Р8"
                },
                new Models.Books()
                {
                    BookId = 57,
                    BookName = "Книга С9",
                    Author = "Автор С9",
                    PageCount = 450,
                    PublishingYear = 1993,
                    EditionNumber = 12,
                    BookPrintNumber = 348,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 18,
                    BooksCountInParty = 28500,
                    PrintingFactoryName = "Книгопечатный завод С9"
                },
                new Models.Books()
                {
                    BookId = 58,
                    BookName = "Книга Т0",
                    Author = "Автор Т0",
                    PageCount = 350,
                    PublishingYear = 1994,
                    EditionNumber = 14,
                    BookPrintNumber = 485,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 1,
                    BooksCountInParty = 92500,
                    PrintingFactoryName = "Книгопечатный завод Т0"
                },
                new Models.Books()
                {
                    BookId = 59,
                    BookName = "Книга У1",
                    Author = "Автор У1",
                    PageCount = 450,
                    PublishingYear = 1995,
                    EditionNumber = 16,
                    BookPrintNumber = 125,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 17,
                    BooksCountInParty = 50500,
                    PrintingFactoryName = "Книгопечатный завод У1"
                },
                new Models.Books()
                {
                    BookId = 60,
                    BookName = "Книга Ф2",
                    Author = "Автор Ф2",
                    PageCount = 400,
                    PublishingYear = 1996,
                    EditionNumber = 18,
                    BookPrintNumber = 475,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 165,
                    BooksCountInParty = 502500,
                    PrintingFactoryName = "Книгопечатный завод Ф2"
                },
                new Models.Books()
                {
                    BookId = 61,
                    BookName = "Книга Х3",
                    Author = "Автор Х3",
                    PageCount = 500,
                    PublishingYear = 1997,
                    EditionNumber = 20,
                    BookPrintNumber = 666,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 451,
                    BooksCountInParty = 442500,
                    PrintingFactoryName = "Книгопечатный завод Х3"
                },
                new Models.Books()
                {
                    BookId = 62,
                    BookName = "Книга Ц4",
                    Author = "Автор Ц4",
                    PageCount = 400,
                    PublishingYear = 1998,
                    EditionNumber = 22,
                    BookPrintNumber = 777,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 461,
                    BooksCountInParty = 255500,
                    PrintingFactoryName = "Книгопечатный завод Ц4"
                },
                new Models.Books()
                {
                    BookId = 63,
                    BookName = "Книга Ч5",
                    Author = "Автор Ч5",
                    PageCount = 500,
                    PublishingYear = 1999,
                    EditionNumber = 24,
                    BookPrintNumber = 888,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 51,
                    BooksCountInParty = 250000,
                    PrintingFactoryName = "Книгопечатный завод Ч5"
                },
                new Models.Books()
                {
                    BookId = 64,
                    BookName = "Книга Ш6",
                    Author = "Автор Ш6",
                    PageCount = 450,
                    PublishingYear = 2010,
                    EditionNumber = 26,
                    BookPrintNumber = 111,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 166,
                    BooksCountInParty = 250000,
                    PrintingFactoryName = "Книгопечатный завод Ш6"
                },
                new Models.Books()
                {
                    BookId = 65,
                    BookName = "Книга Щ7",
                    Author = "Автор Щ7",
                    PageCount = 550,
                    PublishingYear = 2011,
                    EditionNumber = 28,
                    BookPrintNumber = 142,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 185,
                    BooksCountInParty = 42500,
                    PrintingFactoryName = "Книгопечатный завод Щ7"
                },
                new Models.Books()
                {
                    BookId = 66,
                    BookName = "Книга Ъ8",
                    Author = "Автор Ъ8",
                    PageCount = 450,
                    PublishingYear = 2012,
                    EditionNumber = 30,
                    BookPrintNumber = 335,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 513,
                    BooksCountInParty = 9500,
                    PrintingFactoryName = "Книгопечатный завод Ъ8"
                },
                new Models.Books()
                {
                    BookId = 67,
                    BookName = "Книга Ы9",
                    Author = "Автор Ы9",
                    PageCount = 550,
                    PublishingYear = 2013,
                    EditionNumber = 32,
                    BookPrintNumber = 224,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 436,
                    BooksCountInParty = 8500,
                    PrintingFactoryName = "Книгопечатный завод Ы9"
                },
                new Models.Books()
                {
                    BookId = 68,
                    BookName = "Книга Ь0",
                    Author = "Автор Ь0",
                    PageCount = 500,
                    PublishingYear = 2014,
                    EditionNumber = 34,
                    BookPrintNumber = 214,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 25,
                    BooksCountInParty = 5500,
                    PrintingFactoryName = "Книгопечатный завод Ь0"
                },
                new Models.Books()
                {
                    BookId = 69,
                    BookName = "Книга Э1",
                    Author = "Автор Э1",
                    PageCount = 600,
                    PublishingYear = 2015,
                    EditionNumber = 36,
                    BookPrintNumber = 216,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 40,
                    BooksCountInParty = 3500,
                    PrintingFactoryName = "Книгопечатный завод Э1"
                },
                new Models.Books()
                {
                    BookId = 70,
                    BookName = "Книга Ю2",
                    Author = "Автор Ю2",
                    PageCount = 500,
                    PublishingYear = 2016,
                    EditionNumber = 38,
                    BookPrintNumber = 244,
                    BindingType = BooksBindingEnum.Твердый,
                    PartyNumber = 444,
                    BooksCountInParty = 2500,
                    PrintingFactoryName = "Книгопечатный завод Ю2"
                },
                new Models.Books()
                {
                    BookId = 71,
                    BookName = "Книга Я3",
                    Author = "Автор Я3",
                    PageCount = 600,
                    PublishingYear = 2017,
                    EditionNumber = 37,
                    BookPrintNumber = 554,
                    BindingType = BooksBindingEnum.Мягкий,
                    PartyNumber = 25,
                    BooksCountInParty = 25000,
                    PrintingFactoryName = "Книгопечатный завод Я3"
                }
            };

            return books;
        }
    }
}