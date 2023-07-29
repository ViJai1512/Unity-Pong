using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playbutton : MonoBehaviour
{
   public void Playbutton()
    {
        Debug.Log("Play Button was pressed");
        SceneManager.LoadScene("game");
    }

}
