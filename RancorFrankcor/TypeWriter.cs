using System;

namespace RancorFrankcor;

public class TypeWriter
{
    public string Text;
    public int i;

    public void Talk()
    {


        for (int i = 0; i < Text.Length; i++)
        {
            Console.Write(Text[i]);
            Thread.Sleep(40);
        }
    }
}
