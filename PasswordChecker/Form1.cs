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
      String userPassword = txtPassword.Text;

      //makes a dictionary of bools to keep track of the security measures that we thought were relivant.
      //We didn't look anything up, we just went based on our knowledge of password security.
      Dictionary<String, bool> checksDict = Calculations.makeDictionary();

      //sets bool to true if that security measure is accounted for in the user's password
      Calculations.setBools(userPassword, checksDict);

      // checks how many security measures are accounted for
      int checkCounter = Calculations.countBools(checksDict);

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
