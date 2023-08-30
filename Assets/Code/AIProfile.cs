using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public abstract class AIProfile
{
    protected abstract float viewDistance { get; }
    protected abstract float waitForTurn { get; }
    protected abstract List<Vector3> waypoints { get; }
    CharacterController target;
    public abstract void ExecuteProfile();
    public virtual void OnPlayerDetected() => Debug.Log("Player found");
    public abstract void DetectPlayer();
}

public class Guardia : AIProfile
{
    protected override float viewDistance { get => 10f; }

protected override float waitForTurn  { get => 5f; }

    protected override List<Vector3> waypoints => throw new System.NotImplementedException();

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
        base.OnPlayerDetected();
    }
}

public class PatrullaCiclica: AIProfile
{
    protected override float viewDistance => throw new System.NotImplementedException();

    protected override float waitForTurn => throw new System.NotImplementedException();

    protected override List<Vector3> waypoints => throw new System.NotImplementedException();

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
        base.OnPlayerDetected();
    }
}

public class PatrullaPingPong : AIProfile
{
    protected override float viewDistance => throw new System.NotImplementedException();

    protected override float waitForTurn => throw new System.NotImplementedException();

    protected override List<Vector3> waypoints => throw new System.NotImplementedException();

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
        base.OnPlayerDetected();
    }
}