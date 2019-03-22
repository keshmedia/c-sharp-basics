using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
namespace Guess_Number
{
    public partial class MainWindow : Window
    {
  private int lives = 30;
  private int random = 0;
  public MainWindow()
  {
      InitializeComponent();
      Random rnd = new Random();
      random = rnd.Next() % 100;
  }
  private void TxbInput_KeyDown(object sender, KeyEventArgs e)
  {
            //TRY//
      try
      {
 if (lives == 0)
 {
     lblFrom.Content = "You ";
     lblTo.Content = "Lose ";
     return;
 }
 if (e.Key == Key.Enter)
 {
 lives--;

 int userGuessed = Int32.Parse(txbInput.Text);
 if (userGuessed == random)
 {
     lblFrom.Content = "You ";
     lblTo.Content = "Win ";
     return;
 }
 if (userGuessed < random)
 {
     lblFrom.Content = userGuessed;
 }
 else
 {
     lblTo.Content = userGuessed;
 }
 lblStatus.Content = "Remaining Lives:  " + lives;
 if (lives <= 3)
 {
 }
  lblStatus.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
      }
 }
            //CATCH//
 catch
 {
     MessageBox.Show("YOU MUST ENTER A NUMBER !!!!");
 }     }   }}
