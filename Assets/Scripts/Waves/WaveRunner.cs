
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Pool;

public class WaveRunner : MonoBehaviour, IWaveRunner
{
    private EnemyRegistery registery;
    private IPath path;
    private ObjectPool<Enemy> pool;
    public event Action WaveCompleted;
    
    public void Run(WaveDefinition wave)
    {
        
    }

    private IEnumerator SpawnGroup(SpawnGroup group)
    {
       yield return new WaitForEndOfFrame();
    }

    private void CheckCompleted()
    {
        
    }
}
