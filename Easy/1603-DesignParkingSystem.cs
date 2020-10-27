using System;
using System.Collections.Generic;
using System.Text;

/*
    Design a parking system for a parking lot.
    The parking lot has three kinds of parking spaces: big, medium, and small, with a fixed number of slots for each size.

    Implement the ParkingSystem class:

    ParkingSystem(int big, int medium, int small) Initializes object of the ParkingSystem class.
    The number of slots for each parking space are given as part of the constructor.
    bool addCar(int carType) Checks whether there is a parking space of carType for the car that wants to get into the parking lot.
    carType can be of three kinds: big, medium, or small, which are represented by 1, 2, and 3 respectively. 
    A car can only park in a parking space of its carType.
    If there is no space available, return false, else park the car in that size space and return true.
 */
public class Problem1603
{
    public class ParkingSystem
    {
        private int BIG;
        private int MEDIUM;
        private int SMALL;

        public ParkingSystem(int big, int medium, int small)
        {
            BIG = big;
            MEDIUM = medium;
            SMALL = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if(BIG > 0)
                    {
                        BIG--;
                        return true;
                    }
                    break;
                case 2:
                    if (MEDIUM > 0)
                    {
                        MEDIUM--;
                        return true;
                    }
                    break;
                case 3:
                    if (SMALL > 0)
                    {
                        SMALL--;
                        return true;
                    }
                    break;
                default:
                    return false;
            }

            return false;
        }
    }
}

