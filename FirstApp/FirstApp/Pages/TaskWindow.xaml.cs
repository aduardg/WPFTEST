using System.Windows;
using FirstApp.Services;


namespace FirstApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {
        IServiceTest _serviceTest;
        public TaskWindow(IServiceTest serviceTest)
        {
            _serviceTest = serviceTest;            

            MessageBox.Show(_serviceTest.GetDateTimeNow().ToString());
            
            InitializeComponent();
        }
    }
}
