using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class RealRepository
    {
        public string GetDataset(string dataset)
        {
            return SimulatedDatabase.Load(dataset);
        }

        public string GetCustomerByName(string name)
        {
            return SimulatedDatabase.Load(name);
        }

        public string GetAnimalByOwner(string owner)
        {
            return SimulatedDatabase.Load(owner);
        }

        public void SaveDataset(string dataset)
        {
            SimulatedDatabase.Save(dataset);
        }

        public void SaveCustomer(string customer)
        {
            SimulatedDatabase.Save(customer);
        }

        public void SaveAnimal(string animal)
        {
            SimulatedDatabase.Save(animal);
        }
    }
}
