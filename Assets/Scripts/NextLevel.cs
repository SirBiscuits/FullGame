using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
	private RoomTemplates roomlist;
    public void nextLevel()
    {//Reloads the scene for a new map
        SceneManager.LoadScene("Main");

    
    }


}
