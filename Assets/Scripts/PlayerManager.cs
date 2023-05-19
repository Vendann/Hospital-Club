using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static int playerHealth;
    public static bool gameOver;
    public TextMeshProUGUI playerHealthText;
    public GameObject menuPanel;
    void Start()
    {
        playerHealth = 1;
        gameOver = false;
        menuPanel.SetActive(false);
    }

    void Update()
    {
        playerHealthText.text = "" + playerHealth;
        if (gameOver)
        {
            menuPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public static void Damage (int DamageCount)
    {
        playerHealth -= DamageCount;
        if (playerHealth <= 0)
        {
            gameOver = true;
        }
    }
}
