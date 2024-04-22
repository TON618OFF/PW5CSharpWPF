using System;
using System.Collections.Generic;
using System.IO;
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
using practice_5.Models;

namespace practice_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Путь к папке с изображениями
            string directoryPath = "D:\\Vyacheslav\\Study\\Project\\Visual C#\\WPFs\\practice 5\\practice 5\\Images";

            // Получение списка путей к изображениям в папке
            List<string> imagePaths = new List<string>();
            foreach (string file in Directory.GetFiles(directoryPath))
            {
                imagePaths.Add(file);
            }

            // Создание объекта ViewModel
            ImageViewModel viewModel = new ImageViewModel(imagePaths);

            // Привязка ViewModel к окну
            DataContext = viewModel;
        }
    }
}
