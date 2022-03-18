using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpRecapProj.ConsoleApp
{
    public class Console
    {
         public void MainMenu()
        {
            Console.WriteLine("\n1. Add new tattoo.\n" +
                    "2. View all tattoos.\n" +
                    "3. View one tattoo.\n" +
                    "4. Edit tattoo.\n" +
                    "5. Delete tattoo.\n" +
                    "6. Exit.\n"
            );
        }

    }
}