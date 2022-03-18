using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpRecapProj.Repository;


namespace CSharpRecapProj.ConsoleApp
{
    public class UserInterface
    {
        bool isRunning = true;
        CSharpRecapProj _repo = new CSharpRecapProj();

        public void Run()
        {
            _repo.SeedData();

            while (isRunning)
            {
                _console.PrintMainMenu();
                _console.EnterSelection();
                string input = GetUserInput();

                UserInputSwitchCase(input);
            }
        }

        private string GetUserInput()
        {
            return Console.ReadLine();
        }

        private void UserInputSwitchCase(string input)
        {
            switch (input)
            {
                case "1":
                    CreateNewTattoo();
                    break;
                case "2":
                    ViewAllTattoos();
                    break;
                case "3":
                    FilterTattoo();
                    break;
                case "4":
                    ExitApplication();
                    break;
                default:

                    break;
            }
        }

        private void FilterDogs()
        {
            Console.WriteLine("\nDo you want a custom tattoo? ");
            _console.EnterSelection();
            Console.WriteLine("\n1. Yes \n" +
            "2. No");
        }

        public void CreateATattoo()
        {
            _console.EnterAName();
            string tattooName = GetUserInput();

            _console.PrintDesignTypes();
            _console.EnterSelection();
            string designTypeInput = GetUserInput();
            DesignType designType = DesignType.Tribal;

            switch (designTypeInput)
            {
                case "1":
                    designType = DesignType.Tribal;
                    break;
                case "2":
                    designType = DesignType.BlackAndWhite;
                    break;
                case "3":
                    designType = DesignType.HyperRealism;
                    break;
                case "4":
                    designType = DesignType.Lettering;
                    break;
                case "5":
                    designType = designType.PolkTrash;
                    break;
                default:
                    break;

            }

        public void ViewAllTattoos()
        {
            List<Tatto> TattooList = _repo.GetAllTatto();

            foreach (Tattoo tattoo in tattooList)
            {
                _console.PrintTattoo(tattoo);
            }

            _console.PressAnyKeyToContinue();
        }

        private void ExitApplication()
        {
            isRunning = false;
            _console.ExitApplicationMessage();
        }

    }
}