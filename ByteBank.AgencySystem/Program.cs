using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.AgencySystem {
  class Program {
    static void Main(string[] args) {
      

      Console.WriteLine("The application finished! Key enter to exit!");
      Console.ReadLine();
    }

    static void TestCheckingAccountArray() {
      CheckingAccount[] account = new CheckingAccount[]{
        new CheckingAccount(245, 234587),
        new CheckingAccount(245, 236489),
        new CheckingAccount(245, 214587)
    };

      for (int i = 0; i < account.Length; i++) {
        Console.WriteLine($"Account {i}: Agency {account[i].Agency} / Number {account[i].Number}");
      }

      for (int i = 0; i < account.Length; i++) {
        Console.WriteLine($"Account {i}: Agency {account[i].Agency} / Number {account[i].Number}");
      }
    }

    static void TestIntArray() {
      int[] age = new int[5] { 10, 28, 35, 48, 50 };
      double average = 0;

      //age[0] = 50;
      //age[1] = 10;
      //age[2] = 28;
      //age[3] = 35;
      //age[4] = 48;

      for (int i = 0; i < age.Length; i++) {
        average += age[i];
        Console.WriteLine(i);
      }

      average /= age.Length;

      Console.WriteLine($"The average age is {average}");
    }
  }
}
