
using System;

public enum GamePhase
{
    Build,
    Wave,
    Victory,
    Defeat
}

public class GameFlow
{
    private WaveDefinition[] waves;
    private IWaveRunner waveRunner;
    private GamePhase phase;
    private int waveIndex;
    public event Action<GamePhase> PhaseChanged;

    public void StartNextWave()
    {
        
    }

    private void OnWaveCompleted()
    {
        
    }

    private void OnLivesDepleted()
    {
        
    }
}
