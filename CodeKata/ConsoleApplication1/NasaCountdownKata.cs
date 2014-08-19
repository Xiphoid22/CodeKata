using System;

public class NasaCountdownKata : INasaCountdownKata
{
    public int[] Countdown(int start)
    {
        int[] countdown = new int[start + 1];
        for(int i = 0 ; i < start ; i++ )
        {
            countdown[i] = start - i;
        }
        return countdown;
    }
}

public interface INasaCountdownKata
{
    int[] Countdown(int start);
}