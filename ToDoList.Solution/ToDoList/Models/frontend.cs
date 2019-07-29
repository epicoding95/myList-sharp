// using System;
// using System.Collections.Generic;
// using ToDoList.Models;


// namespace frontEnd
// {
//     public class Program
//     {
//         public static void Main()
//         {
//          Console.WriteLine("Welcome to the To Do List");
//          Console.WriteLine("Would you like to add to or view your list?(Add/View)");
//          string addCheck = Console.ReadLine();

//          if(addCheck.ToLower() == "add")
//          {
//              Add();
        
           
    
//          }
//          else if (addCheck.ToLower() == "view")
//          {
//              Item.GetAll();
//             //  Main();
//          }

         
//         }
    
//     public static void Add()
//     {

        
//       Console.WriteLine("Enter the description of the item you would like to add.");
//              string itemAdded = Console.ReadLine();
//              Item newItem = new Item(itemAdded);
//             Console.WriteLine(itemAdded + " has been added to your list");
//             List<Item> result = Item.GetAll();
//             Console.WriteLine("Would you like to add another item or view your list of items? (Add / View");
//             string moreCheck = Console.ReadLine();
//             if (moreCheck.ToLower() == "add")
//             {
//                 Add();
//             }
//             else if (moreCheck.ToLower() == "view")
//             {

//                 foreach(Item i in result)
//                 {
//                     Console.WriteLine("item list    " + i.Description);
//                 }
              
            
//             // Main();
//          }
//     }
// }   
// }
