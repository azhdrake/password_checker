using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordChecker
{
  public partial class PasswordForm : Form
  {
    public PasswordForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      bool specialChar = false;
      bool lengthTen = false;
      bool number = false;
      bool capitalChar = false;
      bool lowerChar = false;
      bool space = false;

      String userPassword = txtPassword.Text;
      String testing = "";

      if (userPassword.Any(char.IsDigit))
      {
        number = true;
        testing += "Digit ";
      }
      if (userPassword.Any(char.IsLower))
      {
        lowerChar = true;
        testing += "Lower ";
      }
      if (userPassword.Any(char.IsUpper))
      {
        capitalChar = true;
        testing += "Capital ";
      }
      if (userPassword.Any(char.IsSymbol) || userPassword.Any(char.IsPunctuation))
      {
        specialChar = true;
        testing += "Special ";
      }
      if (userPassword.Length > 10)
      {
        lengthTen = true;
        testing += "Length ";
      }
      if (userPassword.Any(char.IsWhiteSpace))
      {
        space = true;
        testing += "Space ";
      }

      bool[] checksList = new bool[] { number, lowerChar, capitalChar, specialChar, lengthTen, space};

      int checkCounter = 0;

      foreach(bool check in checksList)
      {
        if (check)
        {
          checkCounter ++;
        }
      }

      if (checkCounter <= 2)
      {
        lblStrength.Text = "Bad!";
        BackColor = Color.Red;
      }
      else if (checkCounter >= 3 && checkCounter <= 4)
      {
        lblStrength.Text = "Okay!";
        BackColor = Color.Yellow;
      }
      else if (checkCounter == 5)
      {
        lblStrength.Text = "Good!";
        BackColor = Color.GreenYellow;
      }
      else if (checkCounter == 6)
      {
        lblStrength.Text = "Very Good!";
        BackColor = Color.Green;
      }
      MessageBox.Show(testing);

    }
  }
}
