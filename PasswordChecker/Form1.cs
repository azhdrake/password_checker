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
      //Bools are to keep track of the ways a password can be secure.
    {
      bool specialChar = false;
      bool lengthTen = false;
      bool number = false;
      bool capitalChar = false;
      bool lowerChar = false;
      bool space = false;

      String userPassword = txtPassword.Text;

      //sets bool to true if that security measure is accounted for in the user's password
      if (userPassword.Any(char.IsDigit))
      {
        number = true;
      }
      if (userPassword.Any(char.IsLower))
      {
        lowerChar = true;
      }
      if (userPassword.Any(char.IsUpper))
      {
        capitalChar = true;
      }
      if (userPassword.Any(char.IsSymbol) || userPassword.Any(char.IsPunctuation))
      {
        specialChar = true;
      }
      if (userPassword.Length > 10)
      {
        lengthTen = true;
      }
      if (userPassword.Any(char.IsWhiteSpace))
      {
        space = true;
      }

      //adds bools to array to make them more countable.
      bool[] checksList = new bool[] { number, lowerChar, capitalChar, specialChar, lengthTen, space};

      int checkCounter = 0;

      // checks how many security measures are accounted for
      foreach(bool check in checksList)
      {
        if (check)
        {
          checkCounter ++;
        }
      }

      // looks at the number of security measures used and rates them.
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
