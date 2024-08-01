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

namespace Адовые_интерфейсы__20
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

        private void ras_click(object sender, RoutedEventArgs e)
        {
            int x, z=0, i, sum=0; //Ввод переменных
            bool f1;
            f1 = Int32.TryParse(chislo.Text, out x);
         

            if (f1 == true && x > 0)
            {
                for (i = 1; i <= x; i++)
                {

                    if (z % 2 == 0) //Проверяем чётность
                    {
                        raschet.Items.Add(z);
                        sum = sum + z; //Ищем сумму
                    }
                    z++;
                }
                rez.Text = Convert.ToString(sum);
            }
            else MessageBox.Show("Просто жмякать кнопочку запрещаю, а отрицательные числа и буквы здесь не приветствуются"); 





        }

        private void about_Click(object sender, RoutedEventArgs e) 
        {
            MessageBox.Show("Горе-дизайнер Бирюков Георгий, ИСП-23. А надо нам найти сумму n целых, четных, случайных чисел, распределенных в диапазоне от 0 до n.Вывести на экран на одной строке сгенерированные числа, на другой строке результат.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void chist_Click(object sender, RoutedEventArgs e)
        {
            raschet.Items.Clear();
            chislo.Clear();
            rez.Clear();
        }
    }
}
