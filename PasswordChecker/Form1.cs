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
      bool letters = false;
      bool number = false;
      bool capitalChar = false;
      bool lowerChar = false;

      String userPassword = txtPassword.Text;

      if (userPassword.Any(char.IsDigit))
      {
        number = true;
      }
      if (userPassword.Any(char.IsLetter))
      {
        letters = true;
      }
      if (userPassword.Any(char.IsLower))
      {
        lowerChar = true;
      }
      if (userPassword.Any(char.IsUpper))
      {
        capitalChar = true;
      }
      if (!userPassword.Any(char.IsLetterOrDigit))
      {
        specialChar = true;
      }
      if (userPassword.Length > 10)
      {
        lengthTen = true;
      }

        specialChar = true;
      bool[] checksList = new bool[] { number, letters, lowerChar, capitalChar, specialChar, lengthTen };

      int counter = 0;

      foreach(bool check in checksList)
      {
        if (check)
        {
          counter ++;
        }
      }


      }
    }
  }
}
