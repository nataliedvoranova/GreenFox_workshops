using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Methods
    {   
        
       /* public static void ListTasks(string path)
        {
            Console.WriteLine(File.ReadAllText(path));
        }*/
        public static void AddTask(string path, string taskToAdd)
        {
            
            File.AppendAllText(path, taskToAdd);
        }
        public static void RemoveTask()
        {
           
        }
        public static void CompleteTask()
        {
            string deleteTask = (Console.ReadLine());
            
        }
    }
    class Program
    {
        /* -l Lists all the tasks
           -a Adds a new task
           -r Removes a task
           -c Completes a task*/

            static void Main(string[] args)
        {
            string defaultMessage = File.ReadAllText("C:/User/User/Downloads/greenfox/todo-app/PrintUsage.txt");
            Console.WriteLine(defaultMessage);

            Methods methods = new Methods();
            string path = "C:/User/User/Downloads/greenfox/todo-app/Tasks.txt";
            File.WriteAllText(path, "Walk the dog\n");
            File.AppendAllText(path, "Buy milk\n");
            File.AppendAllText(path, "Do homework");
            Console.ReadLine();

            switch (args[0])
            {
               
                case "-l":
                    /*Methods.ListTasks(path);*/

                    break;

                case "-a":
                    string newTask = Console.ReadLine();
                    Methods.AddTask(path, newTask);

                    break;

                case "-r":
                    Methods.RemoveTask();

                    break;

                case "-c":
                    Methods.CompleteTask();
                    break;
            }
            Console.ReadLine();
        }
    }
}
