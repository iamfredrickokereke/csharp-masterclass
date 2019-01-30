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

namespace WPF_01C
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
        public int MyProperty
        {
            get
            {
                return (int)GetValue(myDependencyProperty);
            }
            set
            {
                SetValue(myDependencyProperty, value);
            }
        }

        public static readonly DependencyProperty myDependencyProperty = DependencyProperty.Register("My Property", typeof(int), typeof(MainWindow), new PropertyMetadata(0));
        */
        public MainWindow()
        {
            InitializeComponent();
            MySlider.Value = 30;
            MyTextBox.Text = MySlider.Value.ToString();

            /*
            InitializeComponent();
            Grid grid = new Grid();
            this.Content = grid;

            Button btn = new Button();

            btn.Width = 150;
            btn.Height = 100;
            btn.FontSize = 26;

           
            WrapPanel wrapPanel = new WrapPanel();
            TextBlock txt = new TextBlock();
            txt.Text = "Multi";
            txt.Foreground = Brushes.Blue;
            wrapPanel.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Color";
            txt.Foreground = Brushes.Red;
            wrapPanel.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Button";
            txt.Foreground = Brushes.White;
            wrapPanel.Children.Add(txt);

            btn.Content = wrapPanel;
            grid.Children.Add(btn);
            */
        }

        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button was clicked - Direct Event");
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse button went up / was realesed - Bubbling");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse button went up / was realesed - tunneling event");
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Left Mouse button went down - tunneling event");
        }

        private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("RighrMouse button went up - tunneling event");
        }
        */
    }
}
