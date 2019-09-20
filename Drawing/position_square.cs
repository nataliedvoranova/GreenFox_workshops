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

          

            DrawSquare(foxDraw, 50, 50);
           // foxDraw.DrawRectangle(0, 0, 50, 50);
            // create a function that draws one square and takes 3 parameters:
            // the x and y coordinates of the square's top left corner
            // and the foxDraw and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.



        }
        public void DrawSquare(FoxDraw foxDraw, int width, int height)
        {
            
            for (int i=0;i<3*50;i=i+50)
            {
                foxDraw.DrawRectangle(i, i, width, height);
                    }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}