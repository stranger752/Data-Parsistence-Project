using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public NameReader NameReader;
    public TextMeshProUGUI bestScore;
    // Start is called before the first frame update
    void Start()
    {
        NameReader = FindObjectOfType<NameReader>();
        BestPlayer();
        //playerInput.onEndEdit += 
        //NameReader.SubmitName += PlayerNameInput;
    }
    public void BestPlayer()
    {
        if (MainManager.Instance.PlayerName != "")
        {
            bestScore.text = "Best Score : "+MainManager.Instance.PlayerName+
                " : "+MainManager.Instance.HighScore;
        }
       
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
       
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif
    }
   
}
