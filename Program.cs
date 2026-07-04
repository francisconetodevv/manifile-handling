using ByteBankIO;
using ByteBankIO.Handlers;

class Program
{
    static void Main(string[] args)
    {
        var binary = new BinaryStream();
        binary.BinaryWritter();
        binary.BinaryReader();
        
        Console.WriteLine("Aplicação Finalizada");

    }
}