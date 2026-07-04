namespace ByteBankIO
{
    public class FileStreamReaderHandler
    {
        static void FileStreamReaderHandlerEvent(string path)
        {
            var filePath = "/home/francisco/Francisco/Dev/C-Sharp/23.FilesCSharp/contas.txt";

            using (var file = new FileStream(filePath, FileMode.Open))
            {
                var reader = new StreamReader(file);

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var contaCorrente = ConvertDataToContaCorrente(line);

                    Console.WriteLine($"Informações da Conta Corrente | Titular: {contaCorrente.Titular.Nome} | Numero: {contaCorrente.Numero} | Agência: {contaCorrente.Agencia} | Saldo: R$ {contaCorrente.Saldo}");
                }
            }
        }

        static ContaCorrente ConvertDataToContaCorrente(string line)
        {
            var fields = line.Split(',');

            var agency = int.Parse(fields[0]);
            var number = int.Parse(fields[1]);
            var value = double.Parse(fields[2].Replace('.', ','));


            var person = new Cliente();
            person.Nome = fields[3];

            var account = new ContaCorrente(agency, number);
            account.Depositar(value);
            account.Titular = person;

            return account;
        }

    }
}