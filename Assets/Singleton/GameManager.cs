using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    /// <summary>
    /// スコア
    /// </summary>
    public int Score { get; private set; }

    private void Update()
    {
        Score++;
    }
}
