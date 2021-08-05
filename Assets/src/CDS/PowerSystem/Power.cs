using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power
{
    public string name;

    public string description;

    public PowerType type;

    public Power(string name, string description, PowerType type)
    {
        this.name = name;
        this.description = description;
        this.type = type;
    }

    public string getName()
    {
        return name;
    }

    public string getDescription()
    {
        return description;
    }

    public PowerType getType()
    {
        return type;
    }
}
