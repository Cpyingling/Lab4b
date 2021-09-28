/*Author Charles Yingling     Date 9/27/2021
Change the code to work for any number of cars by asking the user to provide the number of cars as input.*/
using System;

class Program {
  public static void Main (string[] args) {
        int carcounter = 0;
        double total = 0;
    //Change of code to work for any number of cars
      Console.WriteLine("Enter number of cars to calculate average speed of:");
        int nbrofcars = Convert.ToInt32(Console.ReadLine());

    while (carcounter < nbrofcars) { //do, for, while
    carcounter++;
    //get inputs for each car
      Console.WriteLine ($"Enter the distance covered by Car#{carcounter}");
        double dist = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine ($"Enter the time taken by Car#{carcounter}");
        double time = Convert.ToDouble(Console.ReadLine());
    //Calculate the speed for each car
        double speed = dist / time;
    //Display the speed for each car.    
      Console.WriteLine ($"The speed of this car is {speed} miles per hour");
        total = total + speed;
     }
     //Calculate the average speed of the 7 cars and display it (outside the loop)
        double average = total / carcounter;
      Console.WriteLine ($"The average speed of the cars is {average} miles per hour");
  }
}