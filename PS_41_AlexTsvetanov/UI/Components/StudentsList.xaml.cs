﻿using DataLayer.Database;
using System.Windows.Controls;

namespace UI.Components
{
    /// <summary>
    /// Interaction logic for StudentsList.xaml
    /// </summary>
    public partial class StudentsList : UserControl
    {
        public StudentsList()
        {
            InitializeComponent();
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                var records = context.Users.ToList();
                students.DataContext = records;
            }
        }
    }
}
