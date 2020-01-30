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
      //Bools are to keep track of the ways a password can be secure.
      Dictionary<String, bool> ChecksDict = new Dictionary<String, bool>();
      ChecksDict.Add("specialChar", false);
      ChecksDict.Add("lengthTen", false);
      ChecksDict.Add("number", false);
      ChecksDict.Add("capitalChar", false);
      ChecksDict.Add("lowerChar", false);
      ChecksDict.Add("space", false);

      String userPassword = txtPassword.Text;

      //sets bool to true if that security measure is accounted for in the user's password
      if (userPassword.Any(char.IsDigit))
      {
        ChecksDict["number"] = true;
      }
      if (userPassword.Any(char.IsLower))
      {
        ChecksDict["lowerChar"] = true;
      }
      if (userPassword.Any(char.IsUpper))
      {
        ChecksDict["capitalChar"] = true;
      }
      if (userPassword.Any(char.IsSymbol) || userPassword.Any(char.IsPunctuation))
      {
        ChecksDict["specialChar"] = true;
      }
      if (userPassword.Length > 10)
      {
        ChecksDict["lengthTen"] = true;
      }
      if (userPassword.Any(char.IsWhiteSpace))
      {
        ChecksDict["space"] = true;
      }

      int checkCounter = 0;

      // checks how many security measures are accounted for
      foreach(bool check in ChecksDict.Values)
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

    }
  }
}
