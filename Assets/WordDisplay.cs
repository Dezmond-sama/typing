using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public Color color = Color.red;
    public float fallSpeed = 1f;

    public void SetWord(string word)
    {
        text.text = word;
    }
    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = color;
    }
    public void RemoveWord()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        if (transform.position.y <= -6f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
