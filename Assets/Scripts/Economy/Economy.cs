
using System;

public class Economy
{
    private int gold;
    public event Action<int> GoldChanged;

    public bool CanAfford(int cost)
    {
        return false;
    }

    public bool TrySpend(int cost)
    {
        return false;
    }

    public void Add(int amount)
    {
        
    }
}
