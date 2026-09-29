
using System;
using System.Collections.Generic;

public class EnemyRegistery
{
    public IReadOnlyList<Enemy> Alive;
    public event Action<Enemy> Died;
    public event Action<Enemy> Leaked;

    public void Register(Enemy enemy)
    {
        
    }
}
