using DataLayer.Database;
using Microsoft.EntityFrameworkCore;
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

namespace UI.Components
{
    /// <summary>
    /// Interaction logic for LogList.xaml
    /// </summary>
    public partial class LogList : UserControl
    {
        public LogList()
        {
            InitializeComponent();
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                var records = context.Logs.ToList();
                logs.DataContext = records;
            }
        }
    }
}
