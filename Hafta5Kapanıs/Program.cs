
using Hafta5Kapanıs;
List<Car> carList = new List<Car>();
while (true)
{
    
        Console.WriteLine("Araba üretmek istiyor musunuz?(e/h)");
        string userAnswer = Console.ReadLine().Trim().ToLower();
        if (userAnswer == "e")
        {
            Console.WriteLine("Araba markası girin: ");
            string carBrand = Console.ReadLine();
            Console.WriteLine("Araba modeli girin: ");
            int carModel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Araba seri no girin: ");
            int carSerial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Araba rengi girin: ");
            string carColor = Console.ReadLine();
            int carDoor = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Kapı sayısını girin 2 veya 4 olmalıdır :");
                    carDoor = Convert.ToInt32(Console.ReadLine());
                    if (carDoor == 2 || carDoor == 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Kapı sayısı sadece 2 veya 4 olabilir.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Kapı sayısı sayısal bir değer olmalıdır.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Hatali giris yaptiniz.");
                }
            }
            Car car = new Car(carSerial, carBrand, carModel, carColor, carDoor, DateTime.Now);
            carList.Add(car);
        }
        else if (userAnswer == "h")
        {
            
                foreach (var cars in carList)
                {
                    Console.WriteLine(cars.ToString());
                }

                break;
            
        }
        else
        {
            Console.WriteLine("Geçersiz cevap, lütfen 'e' ya da 'h' olarak cevaplayın ");
        }
}


