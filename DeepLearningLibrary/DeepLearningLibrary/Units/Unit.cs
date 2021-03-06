﻿namespace DeepLearningLibrary.Units
{
    public abstract class Unit
    {
        public abstract double Compute(double[] input);

        public abstract virtual void Randomize();
    }
}
