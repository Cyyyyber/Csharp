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

namespace galgje_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string woord1;
        private int levens = 10;
        string juistGeraden;
        string foutGeraden;
        //private StringBuilder stringBouwer;

        //char[] foutGeraden;


        public MainWindow()
        {
            InitializeComponent();

            text.Text = "Speler 1 klik op nieuw spel";
            btnRaad.Visibility = Visibility.Hidden;

            //StringBuilder stringBouwer = new StringBuilder("ABC", 10);

       


        }



        private void btnVerberg_Click(object sender, RoutedEventArgs e)
        {
            btnVerberg.Visibility = Visibility.Hidden;
            btnRaad.Visibility = Visibility.Visible;
            woord1 = txbInput.Text;

            txbInput.Text = "";
            text.Text = $"Je begint met {levens} levens.";

        }

        private void btnNieuw_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "Speler 2 geef een woord en klik op verbergen";

        }

        private void btnRaad_Click(object sender, RoutedEventArgs e)
        {
            if (woord1.Length > 1)
            {
                if (woord1 == txbInput.Text)
                {
                    text.Text = $"Je hebt het woord geraden! \n\r {woord1}";

                } 
                else
                {
                    txbInput.Text = foutGeraden;

                    levens--;
                    text.Text = $"fout geraden. je verliest een leven, je hebt nu {levens} levens over. \n\r Fout geraden letters: {foutGeraden}  \n\r Juist geraden letters: {juistGeraden}";
                    txbInput.Text = "";
                    

                    //stringBouwer.Append($"fout geraden.je verliest een leven, je hebt nu {levens} levens over. \n\r Fout geraden letters: {foutGeraden}  \n\r Juist geraden letters: {juistGeraden}");
                    //txbInput.Text = "";
                }
    
            }
            if (txbInput.Text.Length == 1)
            {

                if(woord1.Contains(txbInput.Text))
                {
                    txbInput.Text = juistGeraden;
                    text.Text = $"Goed, je hebt een karakter geraden! \n\r Fout geraden letters:  {foutGeraden} \n\r Juist geraden letters: {juistGeraden}";
                    txbInput.Text = "";
                }
                else
                {
                    txbInput.Text = foutGeraden;
                    levens--;
                    text.Text = $"fout geraden. je verliest een leven, je hebt nu {levens} levens over. \n\r Fout geraden letters: {foutGeraden} \n\r Juist geraden letters: {juistGeraden}";
                    txbInput.Text = "";

                }

                
           
            }
          

        }
        
        
        
    }
}
