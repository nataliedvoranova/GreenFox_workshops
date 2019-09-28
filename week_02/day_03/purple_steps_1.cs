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

           
            foxDraw.SetStrokeThicknes(2);
            foxDraw.SetStrokeColor(Colors.Black);


            DrawSquare(foxDraw, 20, Colors.DarkViolet);

        }
        public void DrawSquare(FoxDraw foxDraw, int size,Color color)
        {
            foxDraw.SetFillColor(color);
            for (int i = 0; i < 19*size; i += size)
            {
                foxDraw.DrawRectangle(0+i, 0+i, size, size);
            }

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
