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

            GeneralTask testy = new GeneralTask();
            testy.file_from = "from";
            testy.file_to = "to";
            testy._name = "name";
            testy.task_state = TaskState.NEW;

            dataGrid.Items.Add(testy);

            SyncTaskClass test2 = new SyncTaskClass();
            test2._name = "test22";
            test2.sync_direction = SyncDirection.BOTH;
            dataGrid.Items.Add(test2);
            //dataGrid.UpdateLayout();
        }
    }
}
