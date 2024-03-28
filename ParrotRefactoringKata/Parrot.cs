using System;
using System.Collections.Generic;
using ParrotRefactoringKata;

namespace ParrotRefactoringKata
{
    public interface IParrot
    {
        double GetSpeed();
        string GetCry();
        double GetBaseSpeed();
    }

    public class EuropeanParrot : IParrot
    {
        public string GetCry()
        {
            return "Sqoork!";
        }

        public double GetSpeed()
        {
            return GetBaseSpeed();
        }

        public double GetBaseSpeed()
        {
            return 12.0;
        }
    }

    public class AfricanParrot : IParrot
    {
        private readonly int NumberOfCoconuts;

        public AfricanParrot(int numberOfCoconuts)
        {
            NumberOfCoconuts = numberOfCoconuts;
        }

        public string GetCry()
        {
            return "Sqaark!";
        }

        public double GetSpeed()
        {
            return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * NumberOfCoconuts);
        }

        public double GetBaseSpeed()
        {
            return 12.0;
        }

        private static double GetLoadFactor()
        {
            return 9.0;
        }
    }

    public class NorwegianParrot : IParrot
    {
        private readonly bool IsNailed;
        private readonly double Voltage;

        public NorwegianParrot(bool isNailed, double voltage)
        {
            IsNailed = isNailed;
            Voltage = voltage;
        }

        public string GetCry()
        {
            return Voltage > 0 ? "Bzzzzzz" : "...";
        }

        public double GetSpeed()
        {
            return IsNailed ? 0 : GetBaseSpeed(Voltage);
        }

        private double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }

        public double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}