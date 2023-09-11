using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnButtonClick(){
        SceneManager.LoadScene(0);
    }
    public void OnButtonClickExit(){
        Application.Quit();
        //you can check if the function works only after the build
    }
}
