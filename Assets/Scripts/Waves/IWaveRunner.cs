
using System;

public interface IWaveRunner
{
    public event Action WaveCompleted;

    public void Run(WaveDefinition wave);
}
