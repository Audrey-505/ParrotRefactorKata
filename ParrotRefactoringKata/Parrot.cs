using System;
using System.Collections.Generic;
using ParrotRefactoringKata;

namespace ParrotRefactoringKata
{
    public interface IParrot
    {
        double GetSpeed();
        string GetCry();
    }

    public class European : IParrot
    {
        public string GetCry()
        {
            return "Sqoork!";
        }

        public double GetSpeed()
        {
            return GetBaseSpeed();
        }

        public static double GetBaseSpeed()
        {
            return 12;
        }
    }

    public class African : IParrot
    {
        private readonly int _numberOfCoconuts;

        public African(int numberOfCoconuts)
        {
            _numberOfCoconuts = numberOfCoconuts;
        }

        public string GetCry()
        {
            return "Sqaark!";
        }

        public double GetSpeed()
        {
            return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
        }

        private static double GetBaseSpeed()
        {
            return 12.0;
        }

        private static double GetLoadFactor()
        {
            return 9.0;
        }
    }

    public class Norwegian : IParrot
    {
        private readonly bool _isNailed;
        private readonly double _voltage;

        public Norwegian(bool isNailed, double voltage)
        {
            _isNailed = isNailed;
            _voltage = voltage;
        }

        public string GetCry()
        {
            return _voltage > 0 ? "Bzzzzzz" : "...";
        }

        public double GetSpeed()
        {
            return _isNailed ? 0 : GetBaseSpeed(_voltage);
        }

        private static double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }

        private static double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}