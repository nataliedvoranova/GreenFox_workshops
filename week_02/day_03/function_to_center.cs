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

            this.AttachDevTools();
      
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
            // Create a function that draws a single line and takes 3 parameters:
            // the x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Fill the canvas with lines from the edges, every 20 px, to the center.

            DrawCentreLine(foxDraw, 0, 0);

        }

        public void DrawCentreLine (FoxDraw foxDraw, int x, int y)
        {
          
            for (int i=0; i<600;i+=20)
            {
                foxDraw.DrawLine(x, y + i, 300,300);
            }
            for (int i = 0; i < 600; i += 20)
            {
                foxDraw.DrawLine(x+600, y + i, 300, 300);
            }
            for (int i = 0; i < 600; i += 20)
            {
                foxDraw.DrawLine(x+i, y, 300, 300);
            }
            for (int i = 0; i < 605; i += 20)
            {
                foxDraw.DrawLine(x+i, y+600, 300, 300);
            }
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
