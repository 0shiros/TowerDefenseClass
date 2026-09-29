using UnityEngine;

public interface ITargetable
{
    public Vector2 Position { get; }
    public float RemainingDistance { get; }
    public bool IsAlive { get; }
}
