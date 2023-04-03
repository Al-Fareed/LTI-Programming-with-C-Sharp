class Program
{
    static void Main(string[] args)
    {
        string brandName = Console.ReadLine();

        string soundQuality = Console.ReadLine();

        string powerMode = Console.ReadLine();


        string batteryCount = Console.ReadLine();

        BluetoothSpeaker speaker = new BluetoothSpeaker(brandName,soundQuality,powerMode, batteryCount);

        Console.WriteLine(speaker.BrandName());
        Console.WriteLine(speaker.SoundQuality());
        Console.WriteLine(speaker.PowerMode());
        Console.WriteLine(speaker.Batteries());
    }
}