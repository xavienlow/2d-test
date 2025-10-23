using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public GameObject gameoverscreen;

    [ContextMenu("Increase score")]
    public void addscore(int scoretoadd)
    {
        score = score + scoretoadd;
        scoretext.text = score.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }
}
