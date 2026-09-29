
using System.Collections.Generic;
using UnityEngine;

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