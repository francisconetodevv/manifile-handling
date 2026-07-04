using System.Text;

namespace ByteBankIO
{
    public class CreateFile
    {
        public void CreateFileEvent()
        {
            var newPathFile = "/home/francisco/Francisco/Dev/C-Sharp/23.FilesCSharp/ExportedFiles.csv";

            using (var filePath = new FileStream(newPathFile, FileMode.Create))
            {
                var accountWithString = "456, 7895, 7892.26, Francisco Neto";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(accountWithString);

                filePath.Write(bytes, 0, bytes.Length);
            }
        }
        public void CreateFileWithLibEvent()
        {
            var newPathFile = "/home/francisco/Francisco/Dev/C-Sharp/23.FilesCSharp/ExportedFiles.csv";

            using (var filePath = new FileStream(newPathFile, FileMode.Create))
            {
                using (var writter = new StreamWriter(filePath))
                {
                    writter.Write("485,69989,478.5,Francisco");
                }
            }
        }
        public void WriteTester()
        {
            var newPathFile = "/home/francisco/Francisco/Dev/C-Sharp/23.FilesCSharp/Teste.txt";

            using (var filePath = new FileStream(newPathFile, FileMode.Create))
            {
                using (var writter = new StreamWriter(filePath))
                {
                    for (int i = 0; i < 1000000; i++)
                    {
                        writter.WriteLine($"Linha {i}");
                        writter.Flush(); //Despeja o Buffer no Stream
                        Console.WriteLine($"A Linha {i} foi escrita no Arquivo. Tecle Enter...");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}