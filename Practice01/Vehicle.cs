// Create a class called Vehicle
// 
// Add properties for Make, Model, and Year
//
// Add a method named DisplayInfo that returns void and does a console ouput to show the Vehicle's property info

class Veheicle  // Vehicle spelled wrong...
{
    public int Make { get; set; }
    public int Model { get; set; }
    public int Year { get; set; }
    public void Display()
    {
        //} didn't need this brace

        System.Console.WriteLine(Make + " " + Model + "" + Year);
    }
}   // was missing the closing brace