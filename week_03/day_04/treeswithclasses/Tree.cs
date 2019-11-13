using System;
using System.Collections.Generic;
using System.Text;

namespace treeswithclasses
{
    /*Create 5 trees
    Store the data of them in variables in your program
    for every tree the program should store its'
    type
    leaf color
    age
    sex
    you can use just variables, or lists and/or maps*/
    class Tree
    {
        public string Type { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public Tree(string type, string colour, int age, string sex)
        {
            Type = type;
            Colour = colour;
            Age = age;
            Sex = sex;
           
        }



    }
}
