class Program
{
    static void Main(string[] args)
    {
        BankTransfer bankTransfer = new BankTransfer();
        int transferAmount = 0, transferMethod;

        if (bankTransfer.config.lang == "en")
        {
            Console.Write("Please insert the amount of money to transfer:");
            transferAmount = int.Parse(Console.ReadLine());

            if (transferAmount <= bankTransfer.config.transfer.threshold)
            {
                Console.WriteLine($"Transfer fee = {bankTransfer.config.transfer.low_fee}");
                Console.WriteLine($"Total amount = {transferAmount + bankTransfer.config.transfer.low_fee}");
            }
            else
            {
                Console.WriteLine($"Transfer fee = {bankTransfer.config.transfer.high_fee}");
                Console.WriteLine($"Total amount = {transferAmount + bankTransfer.config.transfer.high_fee}");
            }

            Console.WriteLine($"Select transfer method:");
            for (int i = 0; i < bankTransfer.config.methods.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {bankTransfer.config.methods[i]}");
            }
            transferMethod = int.Parse(Console.ReadLine());

            Console.WriteLine($"PLease type {bankTransfer.config.confirmation.en} to confirm the transaction:");
            String confirmation = Console.ReadLine();
            if (confirmation == bankTransfer.config.confirmation.id)
            {
                Console.WriteLine("The transfer is completed");
            }
            else
            {
                Console.WriteLine("Transfer is cancelled");
            }
        }
        else if (bankTransfer.config.lang == "id")
        {
            Console.Write("Masukkan jumlah uang yang akan di-transfer:");
            transferAmount = int.Parse(Console.ReadLine());

            if (transferAmount <= bankTransfer.config.transfer.threshold)
            {
                Console.WriteLine($"Biaya transfer = {bankTransfer.config.transfer.low_fee}");
                Console.WriteLine($"Total biaya = {transferAmount + bankTransfer.config.transfer.low_fee}");
            }
            else
            {
                Console.WriteLine($"Biaya transfer = {bankTransfer.config.transfer.low_fee}");
                Console.WriteLine($"Total biaya = {transferAmount + bankTransfer.config.transfer.low_fee}");
            }

            Console.WriteLine($"Pilih metode transfer:");
            for (int i = 0; i < bankTransfer.config.methods.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {bankTransfer.config.methods[i]}");
            }
            transferMethod = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ketik {bankTransfer.config.confirmation.en} untuk mengkonfirmasi transaksi:");
            String confirmation = Console.ReadLine();
            if (confirmation == bankTransfer.config.confirmation.id)
            {
                Console.WriteLine("Proses transfer berhasil");
            }
            else
            {
                Console.WriteLine("Transfer dibatalkan");
            }
        }
        else
        {
            Console.WriteLine("Unknown language");
        }

        //if (bankTransfer.config.lang == "en")
        //{
        //    bankTransfer.SetDefault("id");
        //}
        //else
        //{
        //    bankTransfer.SetDefault("en");
        //}
    }
}
