using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentEvents : WorldEvent
{
    public PresentEvents() : base(EventType.PRESENT)
    {

    }

    public List<WorldEvent> retrieveEvents()
    {
        List<WorldEvent> events = new List<WorldEvent>();
        events.Add(new FightEvent());
        events.Add(new TravelEvent());
        return events;
    }


}
