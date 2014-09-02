using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ScopeRuntime;


public static class MyHelper
{
    private static Int64 GetQuantaTicks()
    {
        TimeSpan quantaSpan = new TimeSpan(0, 0, 30);
        return quantaSpan.Ticks;
    }

    private static Int64 _quantaTicks = GetQuantaTicks();

    public static DateTime DateTimeToQuanta(DateTime time)
    {
        Int64 quantizedTimeInTicks = (time.Ticks/_quantaTicks)*_quantaTicks;
        return new DateTime(quantizedTimeInTicks);
    }
}