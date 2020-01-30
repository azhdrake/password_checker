using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
  static public class Calculations
  {
    static public Dictionary<String, bool> makeDictionary()
    {
      //Bools are to keep track of the ways a password can be secure.
      Dictionary<String, bool> ChecksDict = new Dictionary<String, bool>();
      ChecksDict.Add("specialChar", false);
      ChecksDict.Add("lengthTen", false);
      ChecksDict.Add("number", false);
      ChecksDict.Add("capitalChar", false);
      ChecksDict.Add("lowerChar", false);
      ChecksDict.Add("space", false);
      return ChecksDict;
    }

    static public void setBools(String userPassword, Dictionary<String, bool> checksDict)
    {
      if (userPassword.Any(char.IsDigit))
      {
        checksDict["number"] = true;
      }
      if (userPassword.Any(char.IsLower))
      {
        checksDict["lowerChar"] = true;
      }
      if (userPassword.Any(char.IsUpper))
      {
        checksDict["capitalChar"] = true;
      }
      if (userPassword.Any(char.IsSymbol) || userPassword.Any(char.IsPunctuation))
      {
        checksDict["specialChar"] = true;
      }
      if (userPassword.Length > 10)
      {
        checksDict["lengthTen"] = true;
      }
      if (userPassword.Any(char.IsWhiteSpace))
      {
        checksDict["space"] = true;
      }
    }
    static public int countBools(Dictionary<String, bool> checksDict)
    {
      int checkCounter = 0;
      foreach (bool check in checksDict.Values)
      {
        if (check)
        {
          checkCounter++;
        }
      }
      return checkCounter;
    }
  }
}
