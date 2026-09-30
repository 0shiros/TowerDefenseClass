

using UnityEngine;

public class Tower : MonoBehaviour
{
    private TowerDefinition definition;
    private EnemyRegistery registery;
    private float cooldown;
    public int TotalInvested { get; }
    
    public void Init(TowerDefinition def, EnemyRegistery registry)
    {
        definition = def;
        this.registery = registry;
    }

    public void ApplyUpgrade(TowerDefinition def, int cost)
    {
        
    }
    
    private void Fire(ITargetable target)
    {
        
    }
}
