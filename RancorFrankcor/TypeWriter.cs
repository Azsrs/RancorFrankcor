using System;

namespace RancorFrankcor;

public class TypeWriter //Klass för att lätt skapa text med typewriter effekt
{
    public string Text; //Vad som ska sägas
    public int i; 

    public int TextSpeed; //Hur lång tid mellan att varje bokstav skrivs ut
    public void Talk()
    {


        for (int i = 0; i < Text.Length; i++) //Skriver ut bokstäver en efter en till hela texten har skrivits ut
        {
            Console.Write(Text[i]); //Varje räknevärde motsvarar ett tecken i texten, skrivs ut varje loop
            Thread.Sleep(TextSpeed);
        }
    }
}
