using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

class BankTransfer
{
    public BankTransferConfig config;

    public const String filePath = "bank_transfer_config.json";

    public BankTransferConfig ReadConfigFile()
    {
        String jsonData = File.ReadAllText($"../../../{filePath}");
        this.config = JsonSerializer.Deserialize<BankTransferConfig>(jsonData);
        return this.config;
    }

    public void WriteConfigFile()
    {
        String jsonString = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true});
        File.WriteAllText($"../../../{filePath}", jsonString);
    }

    public void SetDefault(String lang)
    {
        config = new BankTransferConfig(lang, new Transfer(), new List<String>(), new Confirmation());
    }

    public BankTransfer()
    {
        try
        {
            this.config = ReadConfigFile();
        }
        catch (Exception e)
        {
            SetDefault("en");
            WriteConfigFile();
        }
    }
}