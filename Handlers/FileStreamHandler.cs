using System.Text;

namespace ByteBankIO
{
    public class FileStreamHandler
    {
        static void FileStreamHandlerEvent(string filePath)
        {
            // DEBBUG
            // var filePath = "/home/francisco/Francisco/Dev/C-Sharp/23.FilesCSharp/contas.txt";

            if (File.Exists(filePath))
            {
                // using --> Creates a block that object will disposed when the code finish
                // And will close the file
                using (var file = new FileStream(filePath, FileMode.Open))
                {
                    var bytesRead = -1;
                    var buffer = new byte[1024];

                    while (bytesRead != 0)
                    {
                        bytesRead = file.Read(buffer, 0, 1024);
                        WriteBuffer(buffer, bytesRead);
                    }
                }
            }
            else
            {
                Console.Write($"The files doesn't exist the Path described {filePath}");
            }

        }

        public static void WriteBuffer(byte[] buffer, int readBytes)
        {
            var utfEigth = new UTF8Encoding();
            var text = utfEigth.GetString(buffer, 0, readBytes);

            Console.Write(text);

            /* DEBBUG
            foreach (var myByte in buffer)
            {
                Console.Write(myByte);
                Console.Write(" ");
            }
            */
        }
    }
}