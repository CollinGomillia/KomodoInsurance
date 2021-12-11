using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoInsurance.POCO;
using KomodoInsurance.REPO;

namespace KomodoInsurance.UI
{
    public class ProgramUI
    {
        private readonly DeveloperRepo _repo = new DeveloperRepo();
        private readonly DevTeam _devTeam = new DevTeam();
        private readonly Developer _developer = new Developer();

        bool _isRunning = true;

        public void Run()
        {

            while (_isRunning)
            {
                RunMenu();
            }
        }

        private void RunMenu()
        {
            #region
            Console.WriteLine("Welcome to Komodo Insurance! " +
                "1.Create Developer" +
                "2.View Developers" +
                "3.Add developer to team" +
                "4.Remove developer from team" +
                "5.Delete Developer \n" +
                "6. Create team" +
                "6. Exit\n");
            int menuNumber;

            if (int.TryParse(Console.ReadLine(), out menuNumber))
            {
                switch (menuNumber)
                {
                    case 1:
                       
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        _isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please enter 1-6. Press Any Key To Continue");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter 1-6. Press Any Key To Continue");
                Console.ReadKey();
                return;
            }
            #endregion
        }

        private void GetDeveloperFromUser()
        {
            private readonly Developer developer = new Developer();
            Developer input = new Developer();

            Developer developer = new Developer();

            

    
        }
        private DevTeam AddDeveloperFromUser()
        {
            DevTeam devTeam = new DevTeam();
            Console.WriteLine("What is the developer's id number?");
            DevTeam.Id = Console.ReadLine();
            Console.WriteLine("What team would you like to send developer to?\n" +
                "1. DevTeam 1" +
                "2. DevTeam 2");
            DevTeam.DevType = int.Parse(Console.ReadLine()) as DevType;
            return devTeam;


        }
        private void ViewAllDevelopers()
        {
            Console.Clear();

            List<Developer> listOfAllDevelopers = _developer.GetDevelopers();

            foreach (var player in listOfAllDevelopers)
            {
                DisplayDeveloperInfo(developer);

            }
            Console.ReadKey();
        }

        private void CreateDeveloper()
        {
            Console.Clear();


            Console.WriteLine("What's the developer's first name?: ");
            string userInputFirstName = Console.ReadLine();


            Console.WriteLine("What's the developer's last name?: ");
            string userInputLastName = Console.ReadLine();

            Console.WriteLine("What's the developer's Id?: ");
            string userInputId = Console.ReadLine();



            Developer developerToBeAddedToDatabase = new Developer(userInputFirstName, userInputLastName, userId);

            bool isSuccessful = _developerRepo.CreateDeveloper(developerToBeAddedToDatabase);
            if (isSuccessful)
            {
                Console.WriteLine($"{userInputFirstName} was successfully added to database");
            }
            else
            {
                Console.WriteLine($"{userInputFirstName} was not successfully added to database");
            }

        }
    }
}

