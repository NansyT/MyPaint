using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public MainWindow()
        {
            InitializeComponent();
            paintArea.EditingMode = InkCanvasEditingMode.Ink;
            brushColours.ItemsSource = typeof(Colors).GetProperties();
            brushColours.SelectedIndex = 0;
        }
        private void CommonCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            manager.SaveFile(paintArea, @"C:\Users\nann8059\Desktop\MyPain Pics\newImage.png");
            MessageBox.Show("Saved file");
        }

        private void PencilBtn_Click(object sender, RoutedEventArgs e)
        {
            paintArea.EditingMode = InkCanvasEditingMode.Ink;
        }
        private void EraserBtn_Click(object sender, RoutedEventArgs e)
        {
            paintArea.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void BrushColours_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color selectedColour = (Color)(brushColours.SelectedItem as PropertyInfo).GetValue(null, null);
            paintArea.DefaultDrawingAttributes.Color = selectedColour;
        }
    }
}
