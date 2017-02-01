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

namespace WpfPromholComplementary_1
{
    /// <summary>
    /// Interaction logic for MyModuleFrame.xaml
    /// </summary>
    public partial class MyModuleFrame : UserControl
    {
        public MyModuleFrame()
        {
            InitializeComponent();
        }

        public Module ItemSource
        {
            get { return (Module)GetValue(ItemSourceProperty); }
            set { SetValue(ItemSourceProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ItemsSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemSourceProperty =
            DependencyProperty.Register("ItemSource", typeof(Module), typeof(MyModuleFrame), new PropertyMetadata(default(Module)));
    }
}
