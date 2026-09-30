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
    public float RemainingDistance { get; set; }
    public bool IsAlive { get; }

    public void Init(EnemyDefinition def, IPathCursor path)
    {
        definition = def;
        RemainingDistance = path.RemainingDistance;
        cursor = path;
        Health.Heal(def.maxHealth);
        GetComponent<SpriteRenderer>().sprite = definition.prefab.GetComponent<SpriteRenderer>().sprite;
    }

    public void TakeDamage(float amount)
    {
        float damage = amount - definition.armor;
        Health.TakeDamage(damage);
    }

    public void ApplySlowFactor(float factor, float duration)
    {
        float timer = 0;
        
        float previousSpeedMultiplier = speedMultiplier;
        
        speedMultiplier = factor;
        
        while (timer < duration)
        {
            timer += Time.deltaTime;
        }
        
        speedMultiplier = previousSpeedMultiplier;
    }

}


