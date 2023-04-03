using System;

public abstract class Speaker
{
    public abstract string PowerMode();
    public abstract string Batteries();

    public string BrandName(){ return "Brand Name - "+GetName() ;}

    public abstract  string GetName();
   

    public string SoundQuality(){return "Sound Quality - "+GetSound();}

    public abstract  string GetSound();
}

