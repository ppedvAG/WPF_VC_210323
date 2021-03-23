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

namespace Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Zuweisung eines weiteren EventHandlers zu dem Click-Event des Buttons
            Btn_KlickMich.Click += Btn_KlickMich_Click_02;
        }

        //Event-Handler für das Click-Event des Buttons
        private void Btn_KlickMich_Click(object sender, RoutedEventArgs e)
        {
            //? = Nullprüfung des vorherigen Objekts (hier Alternative zu: if(Cbb_Auswahl.SelectedItem != null))
            //Neuzuweisung der Content-Eigenschaft des Labels mit dem ausgewählten Inhalt der ComboBox
            Lbl_Output.Content = (Cbb_Auswahl.SelectedItem as ComboBoxItem)?.Content;

            //MessageBox mit dem Wert des Sliders
            MessageBox.Show(Sdr_Value.Value.ToString());
        }

        //Zweiter Eventhandeler des Buttons (siehe Konstruktor)
        private void Btn_KlickMich_Click_02(object sender, RoutedEventArgs e)
        {
            //MessageBox-Abfrage mit Überprüfung des geklickten Buttons
            MessageBoxResult result = MessageBox.Show("JA oder NEIN", "Meine Frage an dich", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);

            if (result == MessageBoxResult.Yes)
                MessageBox.Show("Schön");
        }

        private void Mit_Neu_Click(object sender, RoutedEventArgs e)
        {
            //Öffen eines neuen Fensters als gleichberechtigtes Fenster
            new MainWindow() { Title = "Neues Fenster" }.Show();

            //Öffnen eines neuen Fensters als Dialogfenster mit Rückgabe des DialogResults
            bool? dialogresult = new MainWindow() { Title = "Neues DialogFenster" }.ShowDialog();
        }

        private void Mit_Beenden_Click(object sender, RoutedEventArgs e)
        {
            //Schließen des Fensters
            this.Close();

            //Beenden der Applikation
            Application.Current.Shutdown();
        }
    }
}
