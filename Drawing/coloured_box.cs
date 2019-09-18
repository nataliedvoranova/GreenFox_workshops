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

            canvas.Width = 400;
            canvas.Height = 400;
            // Draw a box that has different colored lines on each edge.

            foxDraw.DrawLine(100, 100, 0, 100);
            foxDraw.SetStrokeColor(Colors.Pink);
            foxDraw.DrawLine(100, 100, 100, 0);
            foxDraw.SetStrokeColor(Colors.Blue);
            foxDraw.DrawLine(0, 0, 0, 100);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, 100, 0);
            foxDraw.SetStrokeColor(Colors.Red);
        }

        private void SetStrokeColour(Color color)
        {

        }
        

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}