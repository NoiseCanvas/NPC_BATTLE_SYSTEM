using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WorldEvent
{
    public EventType eventType;

    public WorldEvent(EventType type)
    {
        this.eventType = type;
    }

    public EventType GetEventType()
    {
        return this.eventType;
    }
}
