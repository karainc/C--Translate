// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Guest> guests = GetGuests();//GetGuests method defined
        Dictionary<string, List<Guest>> tables = new Dictionary<string, List<Guest>>
        //returns list of Guest objects
        {//iterates over each guest in the guests list.
            { "Table 1", new List<Guest>() },
            { "Table 2", new List<Guest>() }
        };
//iterates over each guest in the guests list.
        foreach (Guest guest in guests)
        {
            // checks if the table1Occupations list contains the occupation of the current guest. If it does, the guest is added to "Table 2" by using the push() function, which is equivalent to the Add() method in C# for adding elements to a list
            List<string> table1Occupations = tables["Table 1"].ConvertAll(g => g.Occupation);
            if (table1Occupations.Contains(guest.Occupation))
            {
                tables["Table 2"].Add(guest);
            }
            else
            {
                tables["Table 1"].Add(guest);
            }
        }

        foreach (string tableName in tables.Keys)
        {
            List<Guest> tableGuests = tables[tableName];
            Console.WriteLine(tableName);
            foreach (Guest guest in tableGuests)
            {
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
            }
        }
    }

    static List<Guest> GetGuests()
    {
        return new List<Guest>
        {
            new Guest
            {
                Name = "Marilyn Monroe",
                Occupation = "entertainer",
                Bio = "(1926 - 1962) American actress, singer, model"
            },
            new Guest
            {
                Name = "Abraham Lincoln",
                Occupation = "politician",
                Bio = "(1809 - 1865) US President during American civil war"
            },
            new Guest
            {
                Name = "Martin Luther King",
                Occupation = "activist",
                Bio = "(1929 - 1968)  American civil rights campaigner"
            },
            new Guest
            {
                Name = "Rosa Parks",
                Occupation = "activist",
                Bio = "(1913 - 2005)  American civil rights activist"
            },
            new Guest
            {
                Name = "Peter Sellers",
                Occupation = "entertainer",
                Bio = "(1925 - 1980) British actor and comedian"
            },
            new Guest
            {
                Name = "Alan Turing",
                Occupation = "computer scientist",
                Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
            },
            new Guest
            {
                Name = "Admiral Grace Hopper",
                Occupation = "computer scientist",
                Bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
            },
            new Guest
            {
                Name = "Indira Gandhi",
                Occupation = "politician",
                Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"
            }
        };
    }
}

class Guest
{
    public string Name { get; set; }
    public string Occupation { get; set; }
    public string Bio { get; set; }
}

