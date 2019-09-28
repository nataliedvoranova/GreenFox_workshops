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
            canvas.Width = 600;
            canvas.Height = 600;

            double columns = canvas.Height/100;
            double rows = canvas.Width/100;

            for (int x= 0; x < rows; x++)
            { for (int y = 0; y < columns; y++)
                {
                    if (x % 2 == 0 && y % 2 == 0)
                    { foxDraw.SetFillColor(Colors.White);
                        foxDraw.DrawRectangle(x*100, y*100, 100,100);
                    }
                    else if (x % 2 != 0 && y % 2 != 0)
                        {
                        foxDraw.SetFillColor(Colors.White);
                        foxDraw.DrawRectangle(x * 100, y * 100, 100, 100);
                    }

                    else if ( x%2 !=0 && y%2==0)
                    {
                        foxDraw.SetFillColor(Colors.Black);
                        foxDraw.DrawRectangle(x * 100, y * 100, 100, 100);
                    }
                    else if (x % 2== 0 && y % 2 != 0)
                    {
                        foxDraw.SetFillColor(Colors.Black);
                        foxDraw.DrawRectangle(x*100, y*100,100, 100);
                    }
                }
                

            }

        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
