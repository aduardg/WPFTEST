using FirstApp.Pages;
using FirstApp.ViewFactory;
using System;
using System.Windows;

namespace FirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IAbstractFactory<TaskWindow> _taskWindow;
        public MainWindow(IAbstractFactory<TaskWindow> taskWindow)
        {
            _taskWindow = taskWindow;

            InitializeComponent();         
        }

        private void button_click(object sender, EventArgs e)
        {
            _taskWindow.Create().Show();
            this.Close();            
        }
    }
}
