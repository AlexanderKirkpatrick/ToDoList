using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static List<string> theList = new List<string>();
    
    public static void Main()
    {
      Console.WriteLine("Welcome to your tasklist!");
      Console.WriteLine("Would you like to add an item to your list!?(Add/View)");
      string userInput = Console.ReadLine();
      bool validInput01 = userInput == "Add";
      bool validInput02 = userInput == "add";
      bool validInput03 = userInput == "View";
      bool validInput04 = userInput == "view";

      if (!(validInput01 || validInput02 || validInput03 || validInput04))
      {
        Console.WriteLine("Type it right!");
        Main();
      }
      else
      {
        if (userInput == "Add" || userInput == "add") 
        {
          AddToList();
        } 
        else 
        { 
          ViewList();
        }
      

         static void AddToList()
        {
          Console.WriteLine("Add To List");
          Console.WriteLine("Please enter the description for the new item.");
          string description = Console.ReadLine();
          theList.Add(description);
          Console.WriteLine(description + ", has been added to your list!");
          Main();
        }

         static void ViewList()
        {
          foreach (var item in theList)
          Console.WriteLine(item + ", ");

          Main();
        } 
      }
    }
  }
}

