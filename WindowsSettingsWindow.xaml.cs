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
using System.Windows.Shapes;

namespace Практика_2._0
{
    /// <summary>
    /// Логика взаимодействия для WindowsSettingsWindow.xaml
    /// </summary>
    public partial class WindowsSettingsWindow : Window
    {
        public WindowsSettingsWindow()
        {
            InitializeComponent();
        }

        private void Exit_b_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void NW_tb_Checked(object sender, RoutedEventArgs e)
        {
            NW_tb.Content = "Выкл";
            MessageBox.Show("Сказано же: пока что ничего");
            NW_tb.Content = "Вкл";
        }
    }
}
