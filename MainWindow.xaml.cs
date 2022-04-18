using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Практика_2._0.Модели;
using Практика_2._0.Сервисы;

namespace Практика_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_b_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Search_b_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Был прожат Поиск");

        }

        private void Setter_form_b_Click(object sender, RoutedEventArgs e)
        {
            WindowsSettingsWindow wsw = new();
            wsw.Show();
        }

        //--------------------------------------------------------------------

        private readonly string PATH = $"{Environment.CurrentDirectory}\\wigDataList.jcon";
        private BindingList<WriterInGreeder> _wigDataList;
        private Файлозапись _файл;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _файл = new Файлозапись(PATH);

            try
            {
                _wigDataList = _файл.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

            AlloyGrider.ItemsSource = _wigDataList;
            _wigDataList.ListChanged += _wigDataList_ListChanged;
        }

        private void _wigDataList_ListChanged(object? sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _файл.SaveData(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }
    }
}
