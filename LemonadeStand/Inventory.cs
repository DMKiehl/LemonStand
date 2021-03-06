﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //SOLID - S - Inventory class is adds or removes items fron inventory when they are bought from the store or used to fill a pitcher.
        // member variables (HAS A)
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;

        // constructor (SPAWNER)
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
        }

        // member methods (CAN DO)
        public void AddLemonsToInventory(int numberOfLemons)
        {
            for (int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for (int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for (int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for (int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }

        public void RemoveLemonsFromInventory(int numberOfLemons)
        {
            for (int i = numberOfLemons; i > 0; i--)
            {
                lemons.RemoveAt(0);
            }
        }

        public void RemoveSugarFromInventory(int numberOfSugarCubes)
        {
            for (int i = numberOfSugarCubes; i > 0; i--)
            {
                sugarCubes.RemoveAt(0);
            }
        }

        public void RemoveIceCubesFromInventory(int numberOfIceCubes)
        {
            for (int i = numberOfIceCubes; i > 0; i--)
            {
                iceCubes.RemoveAt(0);
            }
        }

        public void RemoveCupsFromInventory(int numberOfCups)
        {
            for (int i = numberOfCups; i > 0; i--)
            {
                cups.RemoveAt(0);
            }
        }

        


    }
}
