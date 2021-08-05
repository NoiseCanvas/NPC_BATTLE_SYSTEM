using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLine
{
    public Moment beginning;
    public Moment present;




    public TimeLine(OriginEvent originEvent)
    {
        beginning = new Moment(originEvent);
        present = new Moment(new PresentEvents());
        present.past = beginning;
        beginning.future = present;
    }

    public void InsertMomentAtPresent(Moment insertedMoment)
    {
        Moment previous = this.present.past;

        //Debug.Log("Inserting " + insertedMoment.worldEvent.eventType);

        previous.future = insertedMoment;
        insertedMoment.past = previous;
        insertedMoment.future = present;
        present.past = insertedMoment;
    }


    



}

public class Moment
{
    public Moment future { get; set; }
    public Moment past { get; set; }
    public WorldEvent worldEvent { get; set; }

    public Moment(WorldEvent worldEvent)
    {
        this.worldEvent = worldEvent;
        this.future = null;
        this.past = null;
    }
}
