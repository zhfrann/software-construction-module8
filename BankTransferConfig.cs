class Transfer
{
    public Transfer() {
        this.threshold = 25000000;
        this.low_fee = 6500;
        this.high_fee = 15000;
    }

    public int threshold { get; set; }
    public int low_fee { get; set; }
    public int high_fee { get; set; }
}

class Confirmation
{
    public Confirmation()
    {
        this.en = "yes";
        this.id = "ya";
    }

    public String en { get; set; }
    public String id { get; set; }
}

class BankTransferConfig
{
    public string lang { get; set; }
    public Transfer transfer { get; set; }
    public List<String> methods { get; set; }
    public Confirmation confirmation { get; set; }

    public BankTransferConfig() {}

    public BankTransferConfig(string lang, Transfer transfer, List<String> methods, Confirmation confirmation)
    {
        this.lang = lang;
        this.transfer = transfer;
        this.methods =methods;
        this.confirmation = confirmation;
    }
}