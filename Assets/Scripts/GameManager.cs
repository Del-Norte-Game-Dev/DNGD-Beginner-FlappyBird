using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    static public GameManager Instance => instance;

    [SerializeField] private GameObject endMenu;

    // [SerializeField] private TextMeshProUGUI scoreText;
    // [SerializeField] private TextMeshProUGUI highScoreText;
    // private int score;
    // private int highScore;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        endMenu.SetActive(false);
        DontDestroyOnLoad(this);

        // ResetScore();
        // highScore = 0;
    }

    public void GameOver()
    {
        // UpdateHighScore();

        endMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        endMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // ResetScore();
    }

    // public void AddScore()
    // {
    //     score += 1;
    //     UpdateScore();
    // }

    // public void ResetScore()
    // {
    //     score = 0;
    //     UpdateScore();
    // }

    // public void UpdateScore()
    // {
    //     scoreText.text = score.ToString();
    // }

    // public void UpdateHighScore()
    // {
    //     if (score > highScore)
    //     {
    //         highScore = score;
    //         highScoreText.text = highScore.ToString();
    //     }
    // }
}
