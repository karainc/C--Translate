using System;
using System.Collections.Generic;

Console.WriteLine("My Enemies List!");
Console.WriteLine("----------------");
List<Enemy> enemies = GetEnemies();

foreach (Enemy myEnemy in enemies) //enemy list from line 26, define datatype,
{
    if (myEnemy.IsReallyHated)//boolean, if true, do line 12.
    {
        Console.WriteLine($"{myEnemy.FirstName} {myEnemy.LastName} (Really, really dislike!)");
    }
    else                //boolean, is false, line 16
    {
        Console.WriteLine($"{myEnemy.FirstName} {myEnemy.LastName}");
        myEnemy.SayHello();//() tells that its a method, myEnemy is the obj,
    }
}

Enemy Villian = new Enemy(){
      FirstName = "Barry",
            LastName = "Griffith",
            Offenses = new List<string> {
                "Being a jerk to me in elementary school",
                "Not being nice to me in elementary school"
              },
            IsReallyHated = true
};
// A function to make and return list of enemies
List<Enemy> GetEnemies()
{
    // Make a list of Enemy objects
    //  How would you create a collection of enemy objects in JavaScript?
    List<Enemy> enemies = new List<Enemy> {
        new Enemy {
            FirstName = "Joshua",
            LastName = "Flowers",
            Offenses = new List<string> {
                "Being a jerk to me in elementary school",
                "Not being nice to me in elementary school"
            },
            IsReallyHated = true
        },
        new Enemy { //Enemy is the class
            FirstName = "Darth", //set first name property
            LastName = "Vader",
            Offenses = new List<string> { 
                "Cut off Luke's hand",
                "Murdered all those kids",
                ""
            },
            IsReallyHated = false
        },
        new Enemy {
            FirstName = "Betty",
            LastName = "Rudelady",
            Offenses = new List<string> {
                "Phone calls in the theater",
                "Phone calls on the bus",
                "Phone calls in line at the grocery store",
                "Poor conversationalist"
            },
            IsReallyHated = true
        },
        new Enemy { //create a new obj from the enemy class(blueprint)
            FirstName = "Leon",
            LastName = "Peck",
            Offenses = new List<string> {
                "Keeps giving me a hotplate"
            },
            IsReallyHated = false
        }
    };

    return enemies;
}

// Classes are how we define objects in C#. They help us ensure that our objects always have
//  the correct properties and methods.
// JavaScript is more flexible (but also more error-prone), so you will not need to translate
//  this class into JavaScript
public class Enemy //defines line 6, this is the datatype
{
    public string FirstName { get; set; }//get means read, set means write, bult class called FirstName
    public string LastName { get; set; }
    public bool IsReallyHated { get; set; }
    public List<string> Offenses { get; set; }

    public void SayHello(){
        Console.WriteLine("Hello!");
    }//method that doesnt return-void
}
