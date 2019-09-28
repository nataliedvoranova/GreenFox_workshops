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
            canvas.Width = 600;
            canvas.Height = 600;

            foxDraw.SetFillColor(Colors.Transparent);
            foxDraw.SetStrokeThicknes(2);


             DrawSquare(foxDraw, 20);

           // foxDraw.DrawRectangle(300, 300, 20, 20);

            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

        }
        public void DrawSquare(FoxDraw foxDraw, int size)
        {

            for (int i = size; i < 80; i += 20) 
            { foxDraw.DrawRectangle(300-(i/2), 300-(i/2), i, i);
            }
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}