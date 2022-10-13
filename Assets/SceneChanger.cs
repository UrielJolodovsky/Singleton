using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] string[] sceneNames;
    [SerializeField] int sceneindex;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeScenesSequentially()
    {
        if (sceneindex >= sceneNames.Length)
        {
            sceneindex = 0;
        }
        ChangeSceneAndIncrementIndex();
    }
    void ChangeSceneAndIncrementIndex()
    {
        SceneManager.LoadScene(sceneNames[sceneindex]);
        sceneindex++;
    }
}
