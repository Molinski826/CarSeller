using CarSeller;

Car car1 = new Car("Maserati", "Grecale GT", 2023, 49992);
Car car2 = new Car("GMC", "Hummer EV", 2025, 96550);
Car car3 = new Car("Cadillac", "Escalade", 2024, 125285);

UsedCar usedCar1 = new UsedCar("Honda", "Acty", 1996, 5558, 50727);
UsedCar usedCar2 = new UsedCar("Mitsubishi", "Pajero", 1997, 52500, 96500);
UsedCar usedCar3 = new UsedCar("Land Rover", "Defender", 1997, 61000, 119000);

// Add instances to the static carList in Car class
Car.carList.Add(car1);
Car.carList.Add(car2);
Car.carList.Add(car3);
Car.carList.Add(usedCar1);
Car.carList.Add(usedCar2);
Car.carList.Add(usedCar3);

bool runProgram = true;
int index;
System.Console.WriteLine("Welcome to the car lot! Here is the list of cars:");

Car carChoice = new Car();

do
{
    Car.ListCars();
    System.Console.WriteLine("Please enter the appropriate number of the car you'd like to buy!");
    index = int.Parse(Console.ReadLine());

    if (index >= 1 && index <= Car.carList.Count)
    {
        System.Console.WriteLine("This is your chosen car:");
        System.Console.WriteLine();
        carChoice = Car.carList[index - 1];
        System.Console.WriteLine(carChoice);
        System.Console.WriteLine("Excellent choice! You will be hearing from someone soon");
        Car.Remove(index -1);
        
        runProgram = QuestionUser(runProgram);
    }
    else
    {
        System.Console.WriteLine("Invalid input, please enter a number within the specified range");
    }


} while(runProgram);

static bool QuestionUser(bool answer){
    while(true){
        System.Console.WriteLine("Would you like to continue? Please enter yes or no");
        string choice = Console.ReadLine();
        if (choice.ToLower().Trim() == "yes"){
            answer = true;
            break;
        } 
        else if (choice.ToLower().Trim() == "no"){
            answer = false;
            break;
        } 
        else {
            System.Console.WriteLine("Invalid response");
        }
    }
    return answer;
}

