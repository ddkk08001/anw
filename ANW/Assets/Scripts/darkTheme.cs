using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darkTheme : MonoBehaviour
{
    public bool isdark;
    public GameObject Darktheme;
    public GameObject Whitetheme;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isdark == true)
        {
            Darktheme.SetActive(true);
            Whitetheme.SetActive(false);
        }
        
        if(isdark == false)
        {
            Whitetheme.SetActive(true);
            Darktheme.SetActive(false);
        }
    }

    public void isClicked()
    {
        if(isdark == true)
        {
            isdark = false;
        }
        else
        {
            isdark = true;
        }
    }
}
