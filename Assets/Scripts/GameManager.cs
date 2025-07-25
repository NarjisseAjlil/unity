using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Gm : MonoBehaviour
{
    int score = 0;
    bool isGameOver = false;
    public static Gm instance;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject gameOverText;

    private void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit")&& isGameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
     
    }


     public void InitiateGameOver()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
     
    }
}
