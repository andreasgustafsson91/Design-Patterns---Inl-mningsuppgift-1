using Design_Patterns_Assignment;

using System;

namespace Design_Patterns_Assignment
{
    internal class Repository
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Repository Pattern
            Console.WriteLine("Repository");

            RealRepository rp = new RealRepository();

            //inputs
            string dataset = "Dataset A";
            string customerName = "Steve";
            string animalOwner = "Steve";
            string animal = "Yoda";

            //Repository calls
            rp.GetDataset(dataset);
            rp.GetCustomerByName(customerName);
            rp.GetAnimalByOwner(animalOwner);
            rp.SaveDataset(dataset);
            rp.SaveCustomer(customerName);
            rp.SaveAnimal(animal);

            /*var data = SimulatedDatabase.Load("Dataset A");*/
            /*var customer = SimulatedDatabase.Load("From Table Customer Where Name==Steve");*/ // this is a search
            /*var animal = SimulatedDatabase.Load("From Table Animal Where Owner==Steve");*/ // this is a search
            /*SimulatedDatabase.Save(data);
            SimulatedDatabase.Save(customer);
            SimulatedDatabase.Save(animal);*/
            Console.WriteLine();
        }
        

    }
}