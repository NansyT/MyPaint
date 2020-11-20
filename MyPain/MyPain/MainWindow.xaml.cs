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
using System.Windows.Ink;
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
        enum BrushSizes
        {
            Small = 5,
            Meduim = 10,
            Big = 15
        }
        FileManager manager = new FileManager();
        public MainWindow()
        {
            InitializeComponent();
            brushColours.ItemsSource = typeof(Colors).GetProperties();
            brushColours.SelectedIndex = 7;
            brushSizeBox.ItemsSource = Enum.GetValues(typeof(BrushSizes)).Cast<BrushSizes>();
            brushSizeBox.SelectedIndex = 1;
            SetBrushSettings();
        }
        private void CommonCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_Save(object sender, ExecutedRoutedEventArgs e)
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

        private void BrushSizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BrushSizes selectedBrushSize = (BrushSizes)brushSizeBox.SelectedItem;
            paintArea.DefaultDrawingAttributes.Width = (double)selectedBrushSize;
            paintArea.DefaultDrawingAttributes.Height = (double)selectedBrushSize;
        }

        private void CommandBinding_Executed_Select(object sender, ExecutedRoutedEventArgs e)
        {
            paintArea.EditingMode = InkCanvasEditingMode.Select;
        }

        private void CommandBinding_Executed_New(object sender, ExecutedRoutedEventArgs e)
        {
            paintArea.Strokes.Clear();
        }

        private void SetBrushSettings()
        {
            paintArea.DefaultDrawingAttributes.StylusTip = StylusTip.Rectangle;
            paintArea.SnapsToDevicePixels = true;
        }
    }
}
