using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalityData
{
    string state = "";
    bool concious = true;

    List<PsychoLimiter> psychoLimiters = new List<PsychoLimiter>();

    public MentalityData()
    {
        psychoLimiters.Add(new PsychoLimiter(PsychoType.WILL));
        psychoLimiters.Add(new PsychoLimiter(PsychoType.SADNESS));
        psychoLimiters.Add(new PsychoLimiter(PsychoType.PAIN));
        psychoLimiters.Add(new PsychoLimiter(PsychoType.FEAR));
        psychoLimiters.Add(new PsychoLimiter(PsychoType.DOUBT));
        psychoLimiters.Add(new PsychoLimiter(PsychoType.ANGER));
    }

    public void SetDeltaByType(PsychoType target, int deltaValue)
    {
        psychoLimiters.ForEach(item =>
        {
            if (item.type == target)
            {
                item.delta += deltaValue;
            }
        });
    }

    public void CalculateDelta()
    {
        psychoLimiters.ForEach(IterateLimiter);
        psychoLimiters.ForEach(SetStatus);
    }

    private void IterateLimiter(PsychoLimiter item)
    {
        item.value += item.delta;
        item.delta = 0;
        if(item.value >= item.limit)
        {
            item.isTriggered = true;
        }
        if (item.value < 0)
        {
            item.isTriggered = false;
        }
    }

    private void SetStatus(PsychoLimiter item)
    {
        if (item.isTriggered)
        {
            switch (item.type)
            {
                case PsychoType.WILL:
                    break;
                case PsychoType.SADNESS:
                    break;
                case PsychoType.PAIN:
                    break;
                case PsychoType.FEAR:
                    break;
                case PsychoType.DOUBT:
                    break;
                case PsychoType.ANGER:
                    break;
                default:
                    break;
            }

        }
    }



}

public class PsychoLimiter
{
    public PsychoType type;
    public int value = 0;
    public int delta = 0;
    public int limit = 100;
    public bool isTriggered = false;

    public PsychoLimiter(PsychoType type)
    {
        this.type = type;
    }

}

public enum PsychoType {
    WILL,
    FEAR,
    DOUBT,
    PAIN,
    ANGER,
    SADNESS
}
