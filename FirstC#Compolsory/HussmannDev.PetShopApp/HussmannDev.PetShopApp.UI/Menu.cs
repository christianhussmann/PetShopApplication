using System;
using HussmannDev.PetShopApp.Core.IServices;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.UI
{
    public class Menu
    {
        private IPetService _service;
        
        public Menu(IPetService service)
        {
            _service = service;
        }

        public void Start()
        {
            ShowWelcomeGreeting();
            StartLoop();
        }
        
        
        private void StartLoop()
        {
            int choice;
            while ((choice = GetMainMenuSelection()) != 0)
            {
                if (choice == 1)
                {
                    CreatePet();
                } else if (choice == 2)
                {
                    ReadAllPets();
                }else if (choice == 3)
                {
                    ReadAllPets();
                    Print(StringConstants.DeletePromptMessage);
                    DeletePet(GetPetSearchMenuSelection());
                }else if (choice == 4)
                {
                    ReadAllPets();
                    UpdatePet(GetPetSearchMenuSelection());
                }
                else if(choice == 5)
                {
                    sortByPrice();
                }
                else if (choice == 6)
                {
                    searchPetType();
                }
            }
            
        }

        private void searchPetType()
        {
            throw new NotImplementedException();
        }

        private void sortByPrice()
        {
            throw new NotImplementedException();
        }

        private double getPetPrice()
        {
            while (true)
            {
                var priceString = Console.ReadLine();
                double price;
                if (double.TryParse(priceString, out price))
                {
                    return price;
                }
                Console.WriteLine("You must enter a number!");
            }
        }

        private void CreatePet()
        {
            PrintNewLine();
            Print(StringConstants.CreatePetGreeting);
            Print(StringConstants.PetName);
            var petName = Console.ReadLine();
            Print(StringConstants.PetType);
            var petType = Console.ReadLine();
            Print(StringConstants.PetColor);
            var petColor = Console.ReadLine();
            Print(StringConstants.PetPrice);
            var petPrice = getPetPrice();
            Print(StringConstants.PetBirthDate);
            var petBirthDate = DateTime.Now;
            Print(StringConstants.PetSoldDate);
            var petSoldDate = DateTime.Now;
            
            var pet = new Pet
            {
                Name = petName,
                Type = petType,
                Color = petColor,
                Price = petPrice,
                BirthDate = petBirthDate,
                SoldDate = petSoldDate
            };
            pet = _service.CreatePet(pet);
            Print($"Pet with following properties created - Id: {pet.Id} Name: {pet.Name} Type: {pet.Type} Color: {pet.Color} Price:{pet.Price} Birth Date: {pet.BirthDate} Sold Date:{pet.SoldDate}");
            PrintNewLine();
        }

        private void UpdatePet(int id)
        {
            Console.WriteLine("Enter new pet name:");
            var newName = Console.ReadLine();
            Console.WriteLine("Enter new Type");
            var newType = Console.ReadLine();
            Console.WriteLine("Enter new Color");
            var newColor = Console.ReadLine();
            Console.WriteLine("Enter new Price");
            var newPrice = getPetPrice();
            var pet = _service.ReadPetById(id);
            pet.Name = newName;
            pet.Type = newType;
            pet.Color = newColor;
            pet.Price = newPrice;
            _service.UpdatePet(pet);
            Console.WriteLine($"Pet info updated");
        }

        private void ShowWelcomeGreeting()
        {
            Console.WriteLine(StringConstants.WelcomeGreeting);
        }

        private void ReadAllPets()
        {
            Print("Here are all your pets");
            var pets = _service.ReadAllPets();
            foreach (Pet pet in pets)
            {
                Print($"{pet.Id},{pet.Name}, {pet.Type}, {pet.Color} , {pet.BirthDate}, {pet.SoldDate}, {pet.Price}");
            }
        }
        

        private void Print(string value)
        {
            Console.WriteLine(value);
        }


        private int GetMainMenuSelection()
        {
            ShowMainMenu();
            PrintNewLine();
            var selectionString = Console.ReadLine();
            int selection;
            if (int.TryParse(selectionString, out selection))
            {
                return selection;
            }

            return -1;
        }
        
        

        private void DeletePet(int id)
        {
            var pet = _service.RemovePet(id);
            Console.WriteLine($"{pet.Name} has been deleted");
        }

        private void PleaseTryAgain()
        {
            Print(StringConstants.PleaseSelectCorrectItem);
        }
        
        private void ShowMainMenu()
        {
            PrintNewLine();
            Print(StringConstants.PleaseSelectOneOfTheItemsBelow);
            Print(StringConstants.CreateNewPetMessage);
            Print(StringConstants.ShowAllPetsMenuText);
            Print(StringConstants.DeletePetMessage);
            Print(StringConstants.UpdatePetMessage);
            Print(StringConstants.SortByPriceMessage);
            Print(StringConstants.SearchByTypeMessage);
            Print(StringConstants.ExitMainMenuText);
        }

        private void PrintNewLine()
        {
            Console.WriteLine("");
        }

        private int GetPetSearchMenuSelection()
        {
            var selectionString = Console.ReadLine();
            int selection;
            if (int.TryParse(selectionString, out selection))
            {
                return selection;
            }

            return -1;
        }
    }
    
}
