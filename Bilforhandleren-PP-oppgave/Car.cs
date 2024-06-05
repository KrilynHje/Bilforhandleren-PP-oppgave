using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandleren_PP_oppgave
{
    internal class Car
    {
        public int RegNumber;
        public int ModelYear;
        public int Mileage;
        public string Make;
        public int Price;
        public Car(int regNumber, int modelYear, int mileage, string make, int price )
        {
            RegNumber = regNumber; 
            ModelYear = modelYear; 
            Mileage = mileage; 
            Make = make; 
            Price = price;
            
        }
    }
}
