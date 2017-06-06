// Create a class called Product
// 
// Add properties for ProductId (should be a number type), Name, Price, Description
//
// Add a method named DisplayInfo that returns void and does a console ouput to show the Product's property info
class Product
{
    public int Name { get; set; }
    public int Price { get; set; }
    public int Description { get; set; }
    public int ProductId { get; set; }
   
    System.Console.DisplayInfo( Name+" "+Price+" "+Description+" "+ProductId);
            }
        
}