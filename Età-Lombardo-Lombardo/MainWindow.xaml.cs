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

namespace Età_Lombardo_Lombardo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calcola_Click(object sender, RoutedEventArgs e)
        {
            var birthDay = int.Parse(txtGiorno.Text);
            var birthMonth = int.Parse(txtMese.Text);
            var birthYear = int.Parse(txtAnno.Text);
            var birthDate = new DateTime(birthYear, birthMonth, birthDay);
            var today = DateTime.Today; 
            if(birthDate > today)
            {
                lblRisultato.Content = "Impossibile, non puoi essere nato nel futuro";
            }
            else
            {
                var age = today.Year - birthDate.Year;
                var days = (today - birthDate).TotalDays;
                lblRisultato.Content = $"Hai circa {age} anni e hai esattamente {days} giorni.";
            }
        }
    }
}
