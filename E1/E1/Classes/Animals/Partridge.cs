﻿using System;
using E1.Enums;
using E1.Interfaces;
using Environment = E1.Enums.Environment;

namespace E1.Classes.Animals
{
    public class Partridge:IAnimal , IFlyable , IWalkable
    {
        public Partridge(string name, int age, double speedRate, double health)
        {
            this.Name = name;
            this.Age = age;
            this.Health = health;
            this.SpeedRate = speedRate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public double Health { get; set; }
        public double SpeedRate { get; set; }

        public string EatFood()=>
            $"{this.Name} is a {nameof(Partridge)} and is eating";

        public string Fly()=>
             $"{this.Name} is a {nameof(Partridge)} and is flying";

        public string Move(Environment environment)
        {
            if (environment == Environment.Land)
                return Walk();
            else if (environment == Environment.Air)
                return Fly();
            else
                return $"{this.Name} is a {nameof(Partridge)} and can't move in {environment} environment";
        }

        public string Reproduction(IAnimal animal)=>
             $"{this.Name} is a {nameof(Partridge)} and reproductive with {animal.Name}";

        public string Walk()=>
             $"{this.Name} is a {nameof(Partridge)} and is walking";
    }
}