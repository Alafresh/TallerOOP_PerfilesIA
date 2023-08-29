using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public abstract class AIProfile
{
    public abstract void ExecuteProfile();
    public abstract void OnPlayerDetected();
    public abstract void DetectPlayer();
}

public class Guardia : AIProfile
{
    public override void DetectPlayer()
    {
        throw new System.NotImplementedException();
    }

    public override void ExecuteProfile()
    {
        throw new System.NotImplementedException();
    }

    public override void OnPlayerDetected()
    {
        throw new System.NotImplementedException();
    }
}

public class PatrullaCiclica: AIProfile
{
    public override void DetectPlayer()
    {
        throw new System.NotImplementedException();
    }

    public override void ExecuteProfile()
    {
        throw new System.NotImplementedException();
    }

    public override void OnPlayerDetected()
    {
        throw new System.NotImplementedException();
    }
}

public class PatrullaPingPong : AIProfile
{
    public override void DetectPlayer()
    {
        throw new System.NotImplementedException();
    }

    public override void ExecuteProfile()
    {
        throw new System.NotImplementedException();
    }

    public override void OnPlayerDetected()
    {
        throw new System.NotImplementedException();
    }
}