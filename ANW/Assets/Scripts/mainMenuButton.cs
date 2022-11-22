using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuButton : MonoBehaviour
{
    public void ClickTodo()
    {
        SceneManager.LoadScene("TodoList");
        Debug.Log("Clicked TodoList");
    }

    public void ClickIdea()
    {
        SceneManager.LoadScene("IdeaSketch");
        Debug.Log("Clicked IdeaSketch");
    }
}
