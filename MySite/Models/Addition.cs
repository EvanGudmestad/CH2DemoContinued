﻿namespace MySite.Models
{
    public class Addition
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }
        public int Sum { get; set; } //stale data

        public void CalculateSum()
        {
            Sum = NumberOne + NumberTwo;
        }   
    }
}
