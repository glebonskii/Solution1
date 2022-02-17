using GameDataContext;
using Model;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GameUIi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly GameDbContext Context = new GameDbContext();
        public MainWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = Context.Games.ToList();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameOfGameTextBox.Text != "" && GanreTextBox.Text != "" && ProducerTextBox.Text != ""
              && RealeseDatePicker.SelectedDate != null
              && GameModeTextBox.Text != "" && SoldItemCountTextBox.Text != "")
            {
                Game NewGame = new Game
                {
                    NameOfGame = NameOfGameTextBox.Text,
                    Ganre = GanreTextBox.Text,
                    Producer = ProducerTextBox.Text,
                    Realese = (DateTime)RealeseDatePicker.SelectedDate,
                    GameMode = GameModeTextBox.Text,
                    SoldItemsCount = Int32.Parse(SoldItemCountTextBox.Text)
                };
                Context.Games.Add(NewGame);
                Context.SaveChanges();                
                NameOfGameTextBox.Clear();
                GanreTextBox.Clear();
                ProducerTextBox.Clear();
                RealeseDatePicker.SelectedDate = null;
            }
            else
            {
                MessageBox.Show("Can't save  with empty fields", "Error", MessageBoxButton.OK);
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex MyRegex = new Regex("[^0-9]+]");
            e.Handled = MyRegex.IsMatch(e.Text);
        }
    }
}
