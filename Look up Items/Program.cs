//This application will help user to look up items from a serial codes
//Serial codes for the items consist of {XX}-{YY}-{ZZ}
//{XX} is item's type (01.Shirt, 02.Pants, 03.Skirt, 04.Jacket, default is Accessories)
//{YY} is item's color (BL-Black, GR-Green, RD-Red, BU-Blue, PK-Pink, default is Other)
//{ZZ} is item's size (S-Small, M-Medium, L-Large, default is free-size)

public class Program
{
    static void Main()
{
    Console.Write("Enter product types (ex: 01): ");
    string type = Console.ReadLine();

    Console.Write("Enter color code (ex: BL): ");
    string inputColor = Console.ReadLine();
    string color = inputColor.ToUpper();

    Console.Write("Enter size (ex: S): ");
    string inputSize = Console.ReadLine();
    string  size = inputSize.ToUpper();

    string sku = type+ "-" + color+ "-" +size;
    string productType = "";
    string colorName = "";
    string sizeName = "";

    switch (type)
    {
        case "01":
            productType = "Shirt";
            break;
        case "02":
            productType = "Pants";
            break;
        case "03":
            productType = "Skirt";
            break;
        case "04":
            productType = "Jacket";
            break;
        default:
            productType = "Accessories";
            break;
    }

    switch (color)
    {
        case "BL":
            colorName = "Black";
            break;
        case "GR":
            colorName = "Green";
            break;
        case "RD":
            colorName = "Red";
            break;
        case "BU":
            colorName = "Blue";
            break;
        case "PK":
            colorName = "Pink";
            break;
        default:
            colorName = "Other";
            break;
    }

    switch(size)
    {
        case "S":
            sizeName = "Small";
            break;
        case "M":
            sizeName = "Medium";
            break;
        case "L":
            sizeName = "Large";
            break;
        default:
            sizeName = "Free-size";
            break;
    
    }

    Console.WriteLine($"Product SKU: {sku}");
    Console.WriteLine("You are looking for: " + sizeName + " " + colorName + " " + productType);

}
}