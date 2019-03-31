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

namespace SeisekiApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }




        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Kokugo.Text) & !string.IsNullOrEmpty(Sugaku.Text) & !string.IsNullOrEmpty(Eigo.Text))
            {
                if (int.TryParse(Kokugo.Text, out int Score1))
                {
                    if (int.TryParse(Sugaku.Text, out int Score2))
                    {
                        if (int.TryParse(Eigo.Text, out int Score3))
                        {
                            Sumedscore.Content = (Score1 + Score2 + Score3);
                        }

                        else { Keikoku(); }
                    }
                    else { Keikoku(); }
                }
            }
            else { Keikoku(); }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("使い方:" + Environment.NewLine + "数値を入力して、ボタンをクリックしてください。", "説明");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Kokugo.Text) & !string.IsNullOrEmpty(Sugaku.Text) & !string.IsNullOrEmpty(Eigo.Text))
            {
                if (int.TryParse(Kokugo.Text, out int Score1))
                {
                    if (int.TryParse(Sugaku.Text, out int Score2))
                    {
                        if (int.TryParse(Eigo.Text, out int Score3))
                        {
                            Avgscore.Content = ((Score1 + Score2 + Score3) / 3);
                        }
                        else { Keikoku(); }
                    }
                    else { Keikoku(); }
                }
            }
            else { Keikoku(); }
        }

        void Keikoku()
        {
            MessageBox.Show("数値を入力してください！", "警告");
        }
    }
}