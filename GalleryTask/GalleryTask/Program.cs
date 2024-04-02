using Core.Models;

namespace GalleryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Gallery gallery = new Gallery();
            string answer;
           
            do
            {
                Console.Write("\n1.Salona masin elave etmek ucun\n" +
                    "2.Salondaki masinlari gormek ucun\n" +
                    "3.Axtarmaq ucun\n" +
                    "0.Programdan cixin");
                Console.Write("\nBir secim edin: ");
                answer = Console.ReadLine();

                if (answer == "1")
                {
                    Console.Write("Masinin adini daxil edin: ");
                    string name = Console.ReadLine();
                    int speed;
                    string carCode = "";
                    bool check = false;


                    do
                    {
                        Console.Write("Masinin suretini daxil edin: ");

                    } while (!int.TryParse(Console.ReadLine(), out speed));
                    Console.Write("Carcode daxil edin: ");
                    string a = Console.ReadLine();
                    if(a.Length == 2)
                    {
                        for (int i = 0; i < a.Length; i++)
                        {
                            if (a[i] >= 65 && a[i] <= 90)
                            {
                                carCode += a[i];
                                check = true;


                            }
                            else
                            {
                                Console.WriteLine("Herfler boyuk olmalidir");
                                break;
                            }

                        }
                        if (check)
                        {
                            Car car = new Car(name, speed, carCode);
                            gallery.AddCar(car);
                        }


                    }
                    else
                    {
                        Console.WriteLine("Duzgun uzunluqda daxil edin");
                    }







                }

                if (answer == "2")
                {
                    
                    gallery.ShowAllCars();
                    
                }
                if (answer == "3")
                {
                    string choice;
                    do
                    {
                        Console.Write("\n1.Id gore axtaris et\n" +
                            "2.Carcode gore axtaris et\n" +
                            "3.Speed gore araliq tap\n" +
                            "0.Programda cixis");
                        Console.Write("\nBir secim edin: ");
                        choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            int id;
                            do
                            {
                                Console.Write("Id daxil edin: ");

                            } while (!int.TryParse(Console.ReadLine(), out id));


                            foreach (var car in gallery.FindCarById(id))
                            {
                                Console.Write($"\nId: {car.Id}\n Name: {car.Name}\n Speed: {car.Speed}\n CarCode: {car.CarCode}");
                            }
                        }
                        if (choice == "2")
                        {
                            Console.Write("Axtaris ucun carcode daxil edin: ");
                            string carcode = Console.ReadLine();

                            foreach (var car in gallery.FindCarByCarCode(carcode))
                            {
                                Console.Write($"\nId: {car.Id}\n Name: {car.Name}\n Speed: {car.Speed}\n CarCode: {car.CarCode}");
                            }

                           


                        }
                        if (choice == "3")
                        {

                            int minSpeed;
                            int maxSpeed;
                            do
                            {
                                Console.Write("Minspeed daxil edin: ");

                            } while (!int.TryParse(Console.ReadLine(), out minSpeed));
                            do
                            {
                                Console.Write("Maxspeed daxil edin: ");

                            } while (!int.TryParse(Console.ReadLine(), out maxSpeed));

                            foreach (var car in gallery.FindCarBySpeedInterval(minSpeed, maxSpeed))
                            {
                                Console.Write($"\nId: {car.Id}\n Name: {car.Name}\n Speed: {car.Speed}\n CarCode: {car.CarCode}");
                            }
                        }


                    } while (choice != "0");






                }

            } while (answer != "0");
        }
    }
}
