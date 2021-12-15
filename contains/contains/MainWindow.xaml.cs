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

namespace contains
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string woord;
        private int levens = 10;
        private string foutGeraden;
        private string juistGeraden;
        


        public MainWindow()
        {
            InitializeComponent();

            resultaat.Text = "Speler 1 klik op nieuw spel";
            raad.Visibility = Visibility.Hidden;
        }
    

        private void verberg_Click(object sender, RoutedEventArgs e)
        {
            verberg.Visibility = Visibility.Hidden;
            raad.Visibility = Visibility.Visible;
            woord = input.Text;

            input.Text = "";
            resultaat.Text = $"Je begint met {levens} levens.";
        }
        private void nieuw_Click(object sender, RoutedEventArgs e)
        {
            resultaat.Text = "Speler 2 geef een woord en klik op verbergen";
        }

        private void raad_Click(object sender, RoutedEventArgs e)
        {

            if (input.Text.Length > 1)  //WOORD
            {


                if (woord == input.Text)    //geraden = einde
                {
                    resultaat.Text = $"juist \n\r {woord}";
                }
                else    //fout geraden 
                {
                    if (levens == 0) //levens = 0 einde
                    {
                        resultaat.Text = $"Einde, je hebt {levens} levens \n\r foute letters: {foutGeraden} \n\r juiste letters: {juistGeraden}";
                    }
                    else //levens - 1 opnieuw raden
                    {
                        levens--;
                        resultaat.Text = $"fout, je hebt {levens} levens \n\r foute letters: {foutGeraden} \n\r juiste letters: {juistGeraden}";
                    }
                    
                }

            }
            else    //LETTER
            {
                if (woord.Contains(input.Text)) //woord bevat input = true, juist letter geraden
                {
                    if (juistGeraden.Equals(woord))   //woord geraden
                    {
                        resultaat.Text = $"juist, je hebt het woord {woord} geraden \n\r foute letters: {foutGeraden} \n\r juiste letters: {juistGeraden}";
                    }
                    else //1 letter geraden
                    {
                        input.Text = juistGeraden;
                        resultaat.Text = $"juist, je hebt {levens} levens \n\r foute letters: {foutGeraden} \n\r juiste letters: {juistGeraden}";
                    }
                   
                }
                else //false, fout geraden
                {
                    if (levens == 0) //levens = 0 einde
                    {
                        resultaat.Text = $"Einde, je hebt {levens} levens \n\r foute letters: {foutGeraden} \n\r juiste letters: {juistGeraden}";
                    }
                    else //levens - 1 opnieuw raden
                    {
                        levens--;
                        input.Text = foutGeraden;
                        resultaat.Text = $"fout, je hebt {levens} levens \n\r foute letters: {foutGeraden} \n\r juiste letters: {juistGeraden}";
                    }

                }
                

            }



            /*
            Woord  OF  letter
            
                letter  -   juist   -   toon tekst juist/fout/levens
                            OF      
                            geraden -   einde                                                                            
                            OF
                            fout    -   -1  +   toon tekst juist/fout/levens
                                        OF
                                        0 levens einde


                woord   -   geraden -   einde
                            OF 
                            fout    -   -1  +   toon tekst juist/fout/levens
                                        OF
                                        0 levens einde
                
                            
                        
             
             
             */
        }
    }
}
