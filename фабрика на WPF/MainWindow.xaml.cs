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

namespace фабрика_на_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Войти(object sender, RoutedEventArgs e)
        {
            using (var context = new clothEntities())
            {
                var a = context.Пользователь.Where(l => l.Логин == Логин_лог.Text).Where(p => p.Пароль == Пароль_лог.Password).Select(R => R.Роль);
                var b = context.Пользователь.Where(l => l.Логин == Логин_лог.Text).Where(p => p.Пароль == Пароль_лог.Password).FirstOrDefault();
              
              
                if (Логин_лог.Text  != "" && Пароль_лог.Password !="")
                {  

                  if (a.Count() != 0)
                  { int aa = a.First();
                    var c = context.Роль.Where(s => s.ID == aa).First();

                    Имя_в_инфобордере.Text = b.Имя;
                    Тип_пользователя_в_инфобордере.Text = c.Роль1;

                        Рамка_для_страниц.Navigate(new Page1());
                        Кнопка_выхода.Visibility = Visibility.Visible;
                        Бордер_вход_рег.Visibility = Visibility.Hidden;
                  }
                   else
                   {
                     MessageBox.Show("Не правильный логин или пароль.");
                   }
                }
                else
                {
                    MessageBox.Show("Заполните все поля.");
                }  
            }
        }

        private void регистрация(object sender, RoutedEventArgs e)
        {
            if (имя_рег.Text != "" && пароль_рег.Password != "" && имя_рег.Text != "")
            {
                using (var context = new clothEntities())
                {
                    Пользователь регистр = new Пользователь()
                    {
                        Имя = имя_рег.Text,
                        Логин = логин_рег.Text,
                        Пароль = пароль_рег.Password,
                        Роль = 1
                    };
                    context.Пользователь.Add(регистр);
                    var aad = context.Пользователь.Where(l => l.Логин == логин_рег.Text).Select(R => R.Роль);
                    if (aad.Count() == 0)
                    {
                        context.SaveChanges();
                        MessageBoxResult result = MessageBox.Show("Вы успешно зарегестрировались. Хотите войти?", "Вход", MessageBoxButton.YesNo);
                        if (result == MessageBoxResult.Yes)
                        {
                            Логин_лог.Text = логин_рег.Text;
                            Пароль_лог.Password = пароль_рег.Password;
                            var a = context.Пользователь.Where(l => l.Логин == Логин_лог.Text).Where(p => p.Пароль == Пароль_лог.Password).Select(R => R.Роль);
                            int aa = a.First();
                            var c = context.Роль.Where(s => s.ID == aa).First();
                            var b = context.Пользователь.Where(l => l.Логин == Логин_лог.Text).Where(p => p.Пароль == Пароль_лог.Password).FirstOrDefault();
                            Имя_в_инфобордере.Text = b.Имя;
                            Тип_пользователя_в_инфобордере.Text = c.Роль1;
                        }
                    }
                    else
                        MessageBox.Show("Извините, такой пользователь уже существует");
                    //MessageBoxResult result = MessageBox.Show("Вы успешно зарегестрировались. Хотите войти?", "Вход", MessageBoxButton.YesNo);
                    //if (result == MessageBoxResult.Yes)
                    //{
                    //    Логин_лог.Text = логин_рег.Text;
                    //    Пароль_лог.Password = пароль_рег.Password;
                    //    var a = context.Пользователь.Where(l => l.Логин == Логин_лог.Text).Where(p => p.Пароль == Пароль_лог.Password).Select(R => R.Роль);
                    //    int aa = a.First();
                    //    var c = context.Роль.Where(s => s.ID == aa).First();
                    //    var b = context.Пользователь.Where(l => l.Логин == Логин_лог.Text).Where(p => p.Пароль == Пароль_лог.Password).FirstOrDefault();
                    //    Имя_в_инфобордере.Text = b.Имя;
                    //    Тип_пользователя_в_инфобордере.Text = c.Роль1;
                    //}
                }
            }
            else
            {
               
                MessageBox.Show("Заполните все поля.");
               
            }
        }
        private void Выйти_из_аккаунта(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            Close();
        }
    }
}
