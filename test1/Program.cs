﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            new DogHouse().Run();

        }
    }
}
class Dog
{   //  Dog class is ADT
    public string DogName;
    public int age;
    public string favoriteToy;
    public int milesWalkedPerDay;
}
class DogHouse
{
    Dog D1, D2, D3, D4, Temp;
    string[] DogNames;
    Dog[] Dogs;

    public void Run()
    {


        Dog[] Dogs = new Dog[5];
        DogNames = new string[5] { "Peanut", "Fifi", "Fido", "Clearence", "Bigi" };

        for (int i = 0; i < Dogs.Length; i++)
        {
            Dogs[i] = new Dog();
            Dogs[i].DogName = DogNames[i];
        }
    }
}