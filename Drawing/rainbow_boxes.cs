using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Markup.Xaml;
using GreenFox;
using System.Collections.Generic;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif      
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
             // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).


            List<Color> listOfColours = new List<Color> { Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green,Colors.Blue,Colors.Indigo,Colors.Violet};
        
            int size = 20;
            var distance = (Height - size) / listOfColours.Count;
            int step = 0;


           foreach (var color in listOfColours)
           {
               DrawSquare(foxDraw, (int)(Height - step), color);
               step += (int) distance;
           }

        }
        public void DrawSquare(FoxDraw foxDraw, int size, Color color)
        {
            foxDraw.SetFillColor(color);
            foxDraw.DrawRectangle(Height/2 - size/2, Width / 2 - size / 2, size, size);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}