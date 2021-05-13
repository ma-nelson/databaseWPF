using DatabaseWPF.DataSet1TableAdapters;
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

namespace DatabaseWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataSet1 dataSet = new DataSet1();
        private GameTableAdapter gameTableAdapter = new GameTableAdapter();
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gameTableAdapter.Fill(dataSet.Game);
            DataContext = dataSet.Game.DefaultView;

        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            gameTableAdapter.Update(dataSet);
        }
    }
}
