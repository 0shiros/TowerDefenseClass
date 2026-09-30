
using System.Collections.Generic;
using UnityEngine;

public interface ITargeting
{
    public ITargetable Select(Enemy candidates, Vector3 origin, float range);
}

public interface IHitEffect
{
    public void Apply(HitContext ctx);
}

public class TowerDefinition : ScriptableObject
{
    public string displayName;
    public int cost;
    public float range;
    public float fireRate;
    public float sellRefundRatio;
    public GameObject prefab;
    public GameObject projectilePrefab;
    public ITargeting targeting;
    public List<IHitEffect> onHit;
    public TowerDefinition[] upgrades;
}

