using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyPain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FileManager manager = new FileManager();
        Painter painter = new Painter();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void CommonCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void PaintArea_MouseDown(object sender, MouseButtonEventArgs e)
        {
            painter.GetBrushLocation(paintArea, e);
        }

        private void PaintArea_MouseMove(object sender, MouseEventArgs e)
        {
            paintArea.Children.Add(painter.DrawThinLine(paintArea, e));
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            manager.SaveFile(paintArea, @"C:\Users\nann8059\Desktop\MyPain Pics\newImage.png");
            MessageBox.Show("Saved file");
        }
    }
}
