using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace tic_tac_toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsPlayerOne { get; set; } = true;
        public int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        public void NewGame()
        {
            IsPlayerOne = false;
            counter = 0;
            
            Button_0_0.Content = string.Empty;
            Button_0_1.Content = string.Empty;
            Button_0_2.Content = string.Empty;
            Button_1_0.Content = string.Empty;
            Button_1_1.Content = string.Empty;
            Button_1_2.Content = string.Empty;
            Button_2_0.Content = string.Empty;
            Button_2_1.Content = string.Empty;
            Button_2_2.Content = string.Empty;

            Button_0_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;

        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            IsPlayerOne ^= true;
            counter++;

            if(counter > 9)
            {
                NewGame();
                return;
            }

            var button = sender as Button;

            button.Content = IsPlayerOne ? "O" : "X";

            if (CheckIfPlayerWon())
            {
                counter = 9;
            }

        }
        private bool CheckIfPlayerWon()
        {
            if(Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.Blue;
                Button_0_1.Background = Brushes.Blue;
                Button_0_2.Background = Brushes.Blue;
                return true;
            }
            if (Button_1_0.Content.ToString() != string.Empty && Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.Blue;
                Button_1_1.Background = Brushes.Blue;
                Button_1_2.Background = Brushes.Blue;
                return true;
            }
            if (Button_2_0.Content.ToString() != string.Empty && Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.Blue;
                Button_2_1.Background = Brushes.Blue;
                Button_2_2.Background = Brushes.Blue;
                return true;
            }
            if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_0.Content && Button_2_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.Blue;
                Button_1_0.Background = Brushes.Blue;
                Button_2_0.Background = Brushes.Blue;
                return true;
            }
            if (Button_0_1.Content.ToString() != string.Empty &&  Button_0_1.Content == Button_1_1.Content && Button_2_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.Blue;
                Button_1_1.Background = Brushes.Blue;
                Button_2_1.Background = Brushes.Blue;
                return true;
            }
            if (Button_0_2.Content.ToString() != string.Empty && Button_0_2.Content == Button_1_2.Content && Button_2_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.Blue;
                Button_1_2.Background = Brushes.Blue;
                Button_2_2.Background = Brushes.Blue;
                return true;
            }
            if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.Blue;
                Button_1_1.Background = Brushes.Blue;
                Button_2_2.Background = Brushes.Blue;
                return true;
            }
            if (Button_2_0.Content.ToString() != string.Empty && Button_2_0.Content == Button_1_1.Content && Button_1_1.Content == Button_0_2.Content)
            {
                Button_2_0.Background = Brushes.Blue;
                Button_1_1.Background = Brushes.Blue;
                Button_0_2.Background = Brushes.Blue;
                return true;
            }

            return false;
        }
    }
}
