using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MyPain
{
    class FileManager
    {
        public void SaveFile(Canvas paintArea, string filename)
        {
            RenderTargetBitmap renderBitmap = new RenderTargetBitmap(
             (int)paintArea.Width, (int)paintArea.Height,
             96d, 96d, PixelFormats.Pbgra32);
            // needed otherwise the image output is black
            paintArea.Measure(new Size((int)paintArea.Width, (int)paintArea.Height));
            paintArea.Arrange(new Rect(new Size((int)paintArea.Width, (int)paintArea.Height)));

            renderBitmap.Render(paintArea);

            //JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(renderBitmap));

            using (FileStream file = File.Create(filename))
            {
                encoder.Save(file);
            }
        }
    }
}
