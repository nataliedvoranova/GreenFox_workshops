using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    /* Create Counter class
 which has an integer property
 when creating it should have a default value 0 or we can specify it when creating
 we can Add(number) to this counter another whole number
 or we can Add() without parameters just increasing the counter's value by one
 and we can Get() the current value as string
 also we can Reset() the value to the initial value*/
    class Class_counter
    {
        public int Value { get; set; }
        public int Number { get; set; }

        public void AddingNumber(int value, int number)
        {
            Value = value + number;
        }

        public void AddingOne()
        {
            Value++;
        }

        public void GettingString()
        {
            Value.ToString();
        }

        public void Resetting(int resetvalue)
        {
            Value = resetvalue;
        }   
       
    }
}
