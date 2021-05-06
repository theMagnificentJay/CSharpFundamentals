﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    public class Banana : IFruit
    {
        // Constructors
        public Banana() { }
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        // Properties
        public string Name
        {
            get
            {
                return "Banana";
            }
        }

        public bool IsPeeled { get; private set; }

        // Class method
        public string Peel()
        {
            IsPeeled = true;
            return "You peeled the banana";
        }

    }

    public class Orange : IFruit
    {
        // Constructors
        public Orange() { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        // Properties
        public string Name
        {
            get
            {
                return "Orange";
            }
        }
        public bool IsPeeled { get; private set; }

        // Class method
        // Use the same interface method but bodies can be different as long as the return type matches
        public string Peel()
        {
            if (IsPeeled)
            {
                return "It's already peeled";
            }
            else
            {
                IsPeeled = true;
                return "You peeled the orange";
            }
        }

        // Classes that use interfaces can still have unique properties and methods.
        public string Squeeze()
        {
            return "You squeeze the orange, and juice comes out";
        }
    }

    public class Grape : IFruit
    {
        public string Name
        {
            get
            {
                return "Grape";
            }
        }

        // Hardsetting property as false
        public bool IsPeeled { get; } = false;

        public string Peel()
        {
            return "Who peels grapes?";
        }
    }

    // Make an apple class inheriting from IFruit challenge
    /*public class Apple : IFruit
    {
        public string Name
        {
            get
            {
                return "Apple";
            }
        }

        public bool IsPeeled { get; } = false;

        public string Peel()
        {
            return "You don't need to peel an apple. Just eat it.";
        }
    }*/

    public class Apple : IFruit
    {
        // Lamba or 'phat arrow'
        public string Name => "Apple";

        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            if (IsPeeled)
            {
                return "Ready for pies";
            }
            else
            {
                IsPeeled = true;
                return "You peeled the apple";
            }
        }

        public string Compare(Orange orange)
        {
            return "You can't compare these...";
        }
    }
}
