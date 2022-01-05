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

namespace Sekretariat_DataBaseGrid
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Sekretariat_DataBaseGrid.dbAppSekretariatDataSet dbAppSekretariatDataSet = ((Sekretariat_DataBaseGrid.dbAppSekretariatDataSet)(this.FindResource("dbAppSekretariatDataSet")));
            // Załaduj dane do tabeli tblGrid_Sekretariat. Możesz modyfikować ten kod w razie potrzeby.
            Sekretariat_DataBaseGrid.dbAppSekretariatDataSetTableAdapters.tblGrid_SekretariatTableAdapter dbAppSekretariatDataSettblGrid_SekretariatTableAdapter = new Sekretariat_DataBaseGrid.dbAppSekretariatDataSetTableAdapters.tblGrid_SekretariatTableAdapter();
            dbAppSekretariatDataSettblGrid_SekretariatTableAdapter.Fill(dbAppSekretariatDataSet.tblGrid_Sekretariat);
            System.Windows.Data.CollectionViewSource tblGrid_SekretariatViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tblGrid_SekretariatViewSource")));
            tblGrid_SekretariatViewSource.View.MoveCurrentToFirst();
        }
    }
}
