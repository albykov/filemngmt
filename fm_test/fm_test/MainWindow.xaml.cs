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

namespace fm_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //SyncTaskClass task1 = new SyncTaskClass();
            //ZipTaskClass task2 = new ZipTaskClass();

            //task1.task_id = dataGrid.Items.Add(task1);
            //task2.task_id = dataGrid.Items.Add(task2);
        }

        private void new_task_btn_Click(object sender, RoutedEventArgs e)
        {
            TaskInfoWindow tiw = new TaskInfoWindow(this);
            tiw.Left = this.Left + (this.Width - this.ActualWidth) / 2;
            tiw.Top = this.Top + (this.Height - this.ActualHeight) / 2;
            tiw.ShowDialog();
        }
    }
}
