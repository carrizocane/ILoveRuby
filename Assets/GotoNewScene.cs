using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GotoNewScene : MonoBehaviour {

    public AudioSource click;

	public void LoadNewScene()
    {
        click.Play();
        Invoke("LLOAD",1.5f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    void LLOAD()
    {
        SceneManager.LoadScene("GameScene");
    }
}
