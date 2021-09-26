using UnityEngine;

public class GameFlowManager : MonoBehaviour
{
    #region Singleton

    private static GameFlowManager _instance = null;

    public static GameFlowManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<GameFlowManager>();

                if(_instance == null)
                {
                    Debug.LogError("Fatal Error: GameFlowManager not found");
                }
            }

            return _instance;
        }
    }

    #endregion

    [Header("UI")]
    public UIGameOver GameOverUI;

    public bool IsGameOver { get { return isGameOver; }}

    public bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    public void GameOver()
    {
        isGameOver = true;
        ScoreManager.Instance.SetHighScore();
        GameOverUI.Show();
    }

}//class
