using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public static LevelLoader Instance;
    [SerializeField] int breakableBlocks;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }
    public void DestroyedBlocks()
    {
        breakableBlocks--;
        if(breakableBlocks <= 0)
        {
            LoadNextScene();
        }
    }
    public void LoadLevelOneScene()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadGameOverScene()
    {
        StartCoroutine(waitForsecs());
    }
    IEnumerator waitForsecs()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(4);
    }
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int loadNextScene = currentSceneIndex + 1;

        SceneManager.LoadScene(loadNextScene);
    }
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
