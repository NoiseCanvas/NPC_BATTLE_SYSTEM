using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mentality : Power
{
    private MentalityData data;

    public Mentality() : base("Mentality", "The inner universe of your mind", PowerType.Mentality)
    {
        data = new MentalityData();
    }

    public Mentality(MentalityData data) : base("Mentality", "The inner universe of your mind", PowerType.Mentality)
    {
        this.data = data;
    }
}
