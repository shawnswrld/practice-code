// Create a class called State (like US states...)
// 
// Add properties for Abbreviation, Capital, Population, Name
//
// Add a method named DisplayInfo that returns void and does a console ouput to show the state's property info

class State
{
    public int Abbreviation { get; set; }
    public int Capital { get; set; }
    public int Population { get; set; }
    public int Name { get; set; }
    void Display()
    {
        System.Console.WriteLine(Abbreviation + " " + Capital + " " + Population + " " + Name);
        System.Console.ReadLine();
    }
}