using System;
using System.Windows;
using ClassLibrary1;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string username = Environment.UserName; 
            HelloText.Text = HelloHelper.GetGreeting(username);
        }
    }
}