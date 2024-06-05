namespace Bilforhandleren_PP_oppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            carList.Add(new Car(12345, 2005, 100000, "Toyota", 5000));
            carList.Add(new Car(45913, 2020, 60000, "Volvo", 969000));
            carList.Add(new Car(67890, 2010, 150000, "Ford", 7000));
            carList.Add(new Car(91011, 2001, 200000, "Skoda", 1000));

            List<Car> customerCars = new List<Car>();

            int carRegNrToRemove = 67890;
            Car carToRemove = null;

            bool atDealership = true;

            while (atDealership)
            {
                Console.Clear();
                Console.WriteLine("Welcome to dealership.");
                Console.WriteLine("1. Show cars that are available");
                Console.WriteLine("2. Search by year");
                Console.WriteLine("3. Search by mileage");
                Console.WriteLine("4. Buy a car");
                Console.WriteLine("5. Your cars");
                Console.WriteLine("6. Add car");

                var menuChoice = Console.ReadKey().KeyChar;

                switch (menuChoice)
                {
                    case '1':
                        showCars();
                        break;
                    case '2':
                        searchByYear();
                        break;
                    case '3':
                        searchByMileage();
                        break;
                    case '4':
                        buyCar();
                        break;
                    case '5':
                        showCostumerCars();
                        break;
                    case '6':
                        AddCar();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"\"{menuChoice}\" is not available as a choice.");
                        Console.WriteLine("\nPress any key to go back to the main menu.");
                        Console.Clear();
                        break;
                }
                Console.ReadKey();
            }

            void buyCar()
            {
                Console.Clear();

                Console.WriteLine("Enter the registration number of the car you would like to purchase:");
                int carRegNrToRemove = Convert.ToInt32(Console.ReadLine());

                foreach (var car in carList)
                {
                    if (car.RegNumber == carRegNrToRemove)
                    {
                        carToRemove = car;
                        break;
                    }
                }

                if (carToRemove != null)
                {

                    carList.Remove(carToRemove);


                    customerCars.Add(carToRemove);
                }
                else
                {
                    Console.WriteLine("Car not found.");
                    Console.WriteLine("\nPress any key to go back to the main menu.");
                }

                Console.WriteLine("Congratulations with your new car! ");
                Console.WriteLine($"You are now the proud owner of a {carToRemove.ModelYear}, {carToRemove.Make}");
                Console.WriteLine("\nPress any key to go back to the main menu.");
            }


            void showCars()
            {
                Console.Clear();
                Console.WriteLine("Cars currently for sale: \n");
                foreach (var car in carList)
                {

                    Console.WriteLine($"Registration number: {car.RegNumber} \n Model year: {car.ModelYear} \n Milage: {car.Mileage} \n Make: {car.Make} \n Price: {car.Price} \n");

                }

            }

            void searchByYear()
            {
                Console.Clear();
                Console.WriteLine("Enter year from: ");
                var yearFrom = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter year to: ");
                var yearTo = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                Console.WriteLine($"Here are the cars ranging {yearFrom} - {yearTo}");

                foreach (var car in carList)
                {
                    if (car.ModelYear <= yearTo && car.ModelYear >= yearFrom)
                        Console.WriteLine($"Registration number: {car.RegNumber} \n Model year: {car.ModelYear} \n Milage: {car.Mileage} \n Make: {car.Make} \n Price: {car.Price} \n");
                }



                Console.WriteLine("\nPress any key to go back to the main menu.");

            }

            void searchByMileage()
            {


                Console.Clear();

                Console.WriteLine("Enter minimum milage: ");
                var mileageFrom = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter maximum milage: ");
                var mileageTo = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                Console.WriteLine($"Here are the cars ranging from {mileageFrom} - {mileageTo}");

                foreach (var car in carList)
                {
                    if (car.Mileage <= mileageTo && car.Mileage >= mileageFrom)
                        Console.WriteLine($"Registration number: {car.RegNumber} \n Model year: {car.ModelYear} \n Milage: {car.Mileage} \n Make: {car.Make} \n Price: {car.Price} \n");
                }

                Console.WriteLine("\nPress any key to go back to the main menu.");

            }

            void showCostumerCars()
            {
                Console.Clear();
                Console.WriteLine("Cars in your garage: \n");
                foreach (var car in customerCars)
                {

                    Console.WriteLine($"Registration number: {car.RegNumber} \n Model year: {car.ModelYear} \n Milage: {car.Mileage} \n Make: {car.Make} \n Price: {car.Price} \n");

                }
                Console.WriteLine("\nPress any key to go back to the main menu.");


            }


            void AddCar()
            {
                Console.Clear();
                Console.WriteLine("Adding new car...");
                Console.WriteLine("Registration number of the car:");
                int regNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the model year of the car :");
                int modelYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter mileage of the car :");
                int mileage = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the make of the car:");
                string make = Console.ReadLine();
                Console.WriteLine("Ente the price of the car:");
                int price = int.Parse(Console.ReadLine());  
                carList.Add(new Car (regNumber,modelYear, mileage, make, price));
                Console.WriteLine("New car added successfully!");

                Console.WriteLine("\nPress any key to go back to the main menu.");
            }
        }
    }
}


