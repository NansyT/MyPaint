using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyPain
{
    class Painter
    {
        Point currentPosition = new Point();
        public Point GetBrushLocation(Canvas paintArea, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                return currentPosition = e.GetPosition(paintArea);
            }
            return currentPosition;
        }

        public Line DrawThinLine(Canvas paintArea, MouseEventArgs e)
        {
            Line line = new Line();
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                line.Stroke = Brushes.Black;
                line = GetLine(line, paintArea, e);
                
                return line;
            }
            return line;
        }

        public Line Erase(Canvas paintArea, MouseEventArgs e)
        {
            Line line = new Line();
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                line.Stroke = Brushes.Transparent;
                line = GetLine(line, paintArea, e);

                return line;
            }
            return line;
        }
        //! This Probably needs a new name
        private Line GetLine(Line line, Canvas paintArea, MouseEventArgs e)
        {
            line.ClipToBounds = true;

            line.X1 = currentPosition.X;
            line.Y1 = currentPosition.Y;
            line.X2 = e.GetPosition(paintArea).X;
            line.Y2 = e.GetPosition(paintArea).Y;

            currentPosition = e.GetPosition(paintArea);

            return line;
        }
        //PolyLine attempt
        
    }
}
