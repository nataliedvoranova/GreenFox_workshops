using System;
using Music;

namespace Music
{
    public abstract class Instrument
    {
        protected string Name { get; set; }
        public abstract void Play();
        
        public Instrument()
        {

        }
    }
    public class StringInstrument: Instrument
    {
        public int NumberOfStrings { get; set; }
        
        public override void Play()
        {
                    
            
            /*Electric Guitar(6 strings, "Twang")
        Bass Guitar(4 strings, "Duum-duum-duum")
        Violin(4 strings, "Screech")*/
        }
    }
    public class ElectricGuitar : StringInstrument
    {

    }
    public class BassGuitar : StringInstrument
    {

    }
    public class Violin : StringInstrument
    {

    }
   
}

namespace ConcertHall
{
    public class AppMusic
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test 1, create Electric Guitar, Bass Guitar and Violin with default strings.");
            var guitar = new ElectricGuitar();
            var bassGuitar = new BassGuitar();
            var violin = new Violin();

            Console.WriteLine("Test 1 Play");
            guitar.Play();
            bassGuitar.Play();
            violin.Play();

            Console.WriteLine("Test 2, create Electric Guitar, Bass Guitar with 7 and 5 strings .");
            ElectricGuitar guitar2 = new ElectricGuitar(7);
            BassGuitar bassGuitar2 = new BassGuitar(5);

            Console.WriteLine("Test 2 Play");
            guitar2.Play();
            bassGuitar2.Play();
        }

    }
}