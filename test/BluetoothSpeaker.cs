public class BluetoothSpeaker : Speaker
{
    private string _powerMode;
    private string brandName;
    private string soundQuality;
    // private string _batteryType;
    string  _batteryCount;

    public BluetoothSpeaker(string brandName,string soundQuality, string powerMode,  string batteryCount)
    {
        this.brandName = brandName;
        this.soundQuality = soundQuality;
        _powerMode = powerMode;
        _batteryCount = batteryCount;
    }

    public override string PowerMode()
    {
        return "Power Mode - " + _powerMode;
    }

    public override string Batteries()
    {
        return "Batteries - " + _batteryCount ;
    }

    public override string GetName()
    {
        return brandName ;
    }

    public override string GetSound()
    {
        return soundQuality;
    }
}