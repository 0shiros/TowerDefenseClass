

using UnityEngine;

public class Tower : MonoBehaviour
{
    private TowerDefinition definition;
    private EnemyRegistery registery;
    private float cooldown;
    public int TotalInvested { get; set; }

    public void Init(TowerDefinition def, EnemyRegistery registry)
    {
        definition = def;
        this.registery = registry;
    }

    public void ApplyUpgrade(TowerDefinition def, int cost)
    {
        definition = def;
        TotalInvested += cost;
    }
    
    private void Fire(ITargetable target)
    {
        
    }
}
