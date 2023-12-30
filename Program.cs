using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nokia celular!");
        Smartphone nokia = new Nokia
        {
            Marca = "Nokia",
            Modelo = "Lumia 950",
            IMEI = "123456789012345",
            Memoria = 32
        };

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("Iphone celular!");

        Smartphone iphone = new Iphone
        {
            Marca = "Apple",
            Modelo = "15 Pro Max",
            IMEI = "123456789012349",
            Memoria = 128
        };

        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Snapchat");
    }
}
