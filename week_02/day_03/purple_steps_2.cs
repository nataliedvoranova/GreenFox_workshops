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


            foxDraw.SetStrokeThicknes(1);
            foxDraw.SetStrokeColor(Colors.Black);


            DrawSquare(foxDraw, 4, Colors.DarkViolet);

            /*double startingPoints = 0;
            double rectangleSize = 10;

            foxDraw.SetFillColor(Colors.Purple);
            for (int i = 0; i < 7; i++)
            {
                foxDraw.DrawRectangle(startingPoints, startingPoints, rectangleSize, rectangleSize);
                startingPoints = startingPoints + rectangleSize;
                rectangleSize = rectangleSize * 2;
            }
*/



        }
        public int DrawSquare(FoxDraw foxDraw, int size,Color color)
        {
            foxDraw.SetFillColor(color);

            if (size>252)
            
                return 0;
            for (int i = 0; i < 252; i++)
            {
                foxDraw.DrawRectangle(size, size, size, size);
            }
            return DrawSquare(foxDraw,size*2,Colors.DarkViolet);


            /*for (int i = 1; i < 6 * size; i++)
            {
                foxDraw.DrawRectangle((size*i)*i,(size*i)*i, (size*i)*2, (size*i)*2);
            }*/

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
