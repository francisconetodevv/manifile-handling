namespace ByteBankIO.Handlers
{
    public class BinaryStream
    {
        /// <summary>
        ///     - Armazena em Binário os valores;
        ///     - Mais deixa o processo leve e menos pesado;
        ///     - Encoding
        /// </summary>
        public void BinaryWritter()
        {
            var newPathFile = "/home/francisco/Francisco/Dev/C-Sharp/23.FilesCSharp/BinaryText.txt";

            using (var filePath = new FileStream(newPathFile, FileMode.Create))
            {
                using (var writter = new BinaryWriter(filePath))
                {
                    writter.Write(134);
                    writter.Write(546544);
                    writter.Write(90000.45);
                    writter.Write("Francisco Neto");
                }
            }
        }

        /// <summary>
        ///     - Faz a leitura do Binario -> Respectivos valores;
        ///     - Decoding
        /// </summary>
        public void BinaryReader()
        {
            var newPathFile = "/home/francisco/Francisco/Dev/C-Sharp/23.FilesCSharp/BinaryText.txt";

            using (var filePath = new FileStream(newPathFile, FileMode.Open))
            {
                using (var reader = new BinaryReader(filePath))
                {
                    var agency = reader.ReadInt32();
                    var accountNumber = reader.ReadInt32();
                    var accountBalance = reader.ReadDouble();
                    var user = reader.ReadString();

                    Console.WriteLine($"Agência: {agency}");
                    Console.WriteLine($"Número da Conta: {accountNumber}");
                    Console.WriteLine($"Saldo: {accountBalance}");
                    Console.WriteLine($"Usuário: {user}");
                }
            }
        }
    }
}