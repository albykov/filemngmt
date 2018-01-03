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

namespace fm_test
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class TaskInfoWindow : Window
    {
        public MainWindow mainWindow;
        public TaskInfoWindow()
        {
            InitializeComponent();
        }

        public TaskInfoWindow(MainWindow mWindow)
        {
            InitializeComponent();
            mainWindow = mWindow;
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ok_btn_Click(object sender, RoutedEventArgs e)
        {

            if (taskTypeDDL.SelectedIndex != -1)
            {
                if ((TaskType)taskTypeDDL.SelectedValue == TaskType.SYNC)
                {
                    Console.WriteLine("SYNCxxx");
                    SyncTaskClass newClass = new SyncTaskClass();
                    newClass.task_id = mainWindow.dataGrid.Items.Add(newClass);
                }

                else if ((TaskType)taskTypeDDL.SelectedValue == TaskType.ZIP)
                {
                    Console.WriteLine("ZIPxxx");
                    ZipTaskClass newClass = new ZipTaskClass();
                    newClass.task_id = mainWindow.dataGrid.Items.Add(newClass);
                }
                this.Close();
            }
            else
            {
                Console.WriteLine("NOTHING");
                MessageBox.Show("Task Type is not Selected!", "Task Type", MessageBoxButton.OK);
            }
        }
        
    }
}
