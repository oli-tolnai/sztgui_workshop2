using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sztgui_workshop2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void Add_hero_Click(object sender, RoutedEventArgs e)
        {
            SuperHero newHero = new SuperHero();
            EditorWindow editor = new EditorWindow(newHero);

            if (editor.ShowDialog() == true && this.DataContext is MainWindowViewModel vm)
            {
                vm.AddHero(newHero);
                lbox_left.Items.Refresh();
                lbox_right.Items.Refresh();
            }
        }

        private void Speedup_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}