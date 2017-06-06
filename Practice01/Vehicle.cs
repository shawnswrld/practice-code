// Create a class called Vehicle
// 
// Add properties for Make, Model, and Year
//
// Add a method named DisplayInfo that returns void and does a console ouput to show the Vehicle's property info
class Veheicle
{
    public int Make { get; set; }
    public int Model { get; set; }
    public int Year { get; set; }
    public void Display() {
    }
    
        System.Console.WriteLine(Make + " " + Model + "" + Year);
    }