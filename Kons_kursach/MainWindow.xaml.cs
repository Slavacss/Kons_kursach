using System.Windows;
using Kons_kursach.EFModels;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Controls;
namespace Kons_kursach
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1 db;
        public MainWindow()
        {
            InitializeComponent();
            db = new Model1();
            db.client.Load();// загружаем данные
            clientsGrid.ItemsSource = db.client.ToList();// устанавливаем привязку к кэшу
            //
        }
    }
}
