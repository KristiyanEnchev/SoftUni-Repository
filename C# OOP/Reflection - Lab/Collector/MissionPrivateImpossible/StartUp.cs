﻿using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.CollectGetterAndSetter("Stealer.Haker");
            Console.WriteLine(result);
        }
    }
}
