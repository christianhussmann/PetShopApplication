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
    }
}