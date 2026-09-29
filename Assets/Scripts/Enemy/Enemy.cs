using UnityEngine;
using System;

public interface IPathCursor
{
    public float RemainingDistance { get; }
    public bool Finished { get; }

    public Vector2 Advance(float distance);
}

public class Enemy : MonoBehaviour, IDamageable, ISlowable, ITargetable
{
    private EnemyDefinition definition;
    private IPathCursor cursor;
    private float speedMultiplier;
    public Health Health { get; }
    public event Action<Enemy> ReachedGoal;
    
    public Vector2 Position { get; }
    public float RemainingDistance { get; }
    public bool IsAlive { get; }

    public void Init(EnemyDefinition def, IPathCursor path)
    {
        
    }

    public void TakeDamage(float amount)
    {
        throw new NotImplementedException();
    }

    public void ApplySlowFactor(float factor, float duration)
    {
        throw new NotImplementedException();
    }

}


