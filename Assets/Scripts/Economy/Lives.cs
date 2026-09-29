
using System;

public class Lives
{
    private int current;
    public event Action<int> Changed;
    public event Action Depleted;

    public void Lose(int amount)
    {
        
    }
}
