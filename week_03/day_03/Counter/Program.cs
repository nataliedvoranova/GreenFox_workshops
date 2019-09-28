using System;

namespace Counter
{
            /*Create Counter class
        which has an integer property
        when creating it should have a default value 0 or we can specify it when creating
        we can Add(number) to this counter another whole number
        or we can Add() without parameters just increasing the counter's value by one
        and we can Get() the current value as string
        also we can Reset() the value to the initial value*/
    class Program
    {
        static void Main(string[] args)
        {
            Class_counter valueOne = new Class_counter ();
            Class_counter valueTwo = new Class_counter ();
            Class_counter valueThree = new Class_counter ();

            Class_counter numberOne = new Class_counter();
            Class_counter numberTwo = new Class_counter();
           

            int defaultValue = 0;

            valueOne.Value = defaultValue;
            valueTwo.Value = 3;
            valueThree.Value = 18;

            int resetValueTwo = valueTwo.Value;
            int resetValueOne = valueOne.Value;
            int restValueThree = valueThree.Value;

            numberOne.Number = 5;
            numberTwo.Number = 10;

            valueOne.AddingNumber(valueOne.Value, numberOne.Number);
            Console.WriteLine(valueOne.Value);

            valueTwo.AddingOne();
            Console.WriteLine(valueTwo.Value);

            valueThree.GettingString();
            Console.WriteLine(valueThree.Value);

            valueTwo.Resetting(resetValueTwo);
            Console.WriteLine(valueTwo.Value);

            valueOne.Resetting(resetValueOne);
            Console.WriteLine(valueOne.Value);

        }
    }
}
