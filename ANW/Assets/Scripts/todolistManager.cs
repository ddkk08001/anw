using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class todolistManager : MonoBehaviour
{
    public GameObject input1;
    public GameObject input2;
    public GameObject input3;
    public GameObject input4;
    public GameObject input5;
    public GameObject input6;
    public GameObject input7;
    public GameObject input8;
    public GameObject input9;
    public GameObject input10;

    //1 True | 0 False
    private int isInput1on;
    private int isInput2on;
    private int isInput3on;
    private int isInput4on;
    private int isInput5on;
    private int isInput6on;
    private int isInput7on;
    private int isInput8on;
    private int isInput9on;
    private int isInput10on;

    // Start is called before the first frame update
    void Start()
    {
        resetprog();
        LoadSavedData();
        LoadCorrectly();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void resetprog()
    {
        input1.gameObject.SetActive(false);
        input2.gameObject.SetActive(false);
        input3.gameObject.SetActive(false);
        input4.gameObject.SetActive(false);
        input5.gameObject.SetActive(false);
        input6.gameObject.SetActive(false);
        input7.gameObject.SetActive(false);
        input8.gameObject.SetActive(false);
        input9.gameObject.SetActive(false);
        input10.gameObject.SetActive(false);

        isInput1on = 0;
        isInput2on = 0;
        isInput3on = 0;
        isInput4on = 0;
        isInput5on = 0;
        isInput6on = 0;
        isInput7on = 0;
        isInput8on = 0;
        isInput9on = 0;
        isInput10on = 0;
    }

    void LoadSavedData()
    {
        isInput1on = PlayerPrefs.GetInt("Input1");
        isInput1on = PlayerPrefs.GetInt("Input2");
        isInput1on = PlayerPrefs.GetInt("Input3");
        isInput1on = PlayerPrefs.GetInt("Input4");
        isInput1on = PlayerPrefs.GetInt("Input5");
        isInput1on = PlayerPrefs.GetInt("Input6");
        isInput1on = PlayerPrefs.GetInt("Input7");
        isInput1on = PlayerPrefs.GetInt("Input8");
        isInput1on = PlayerPrefs.GetInt("Input9");
        isInput1on = PlayerPrefs.GetInt("Input10");
    }

    void LoadCorrectly()
    {
        if(isInput1on == 1)
        {
            input1.gameObject.SetActive(true);
        }

        if (isInput2on == 1)
        {
            input2.gameObject.SetActive(true);
        }

        if (isInput3on == 1)
        {
            input3.gameObject.SetActive(true);
        }

        if (isInput4on == 1)
        {
            input4.gameObject.SetActive(true);
        }

        if (isInput5on == 1)
        {
            input5.gameObject.SetActive(true);
        }

        if (isInput6on == 1)
        {
            input6.gameObject.SetActive(true);
        }

        if (isInput7on == 1)
        {
            input7.gameObject.SetActive(true);
        }

        if (isInput8on == 1)
        {
            input8.gameObject.SetActive(true);
        }

        if (isInput9on == 1)
        {
            input9.gameObject.SetActive(true);
        }

        if (isInput10on == 1)
        {
            input10.gameObject.SetActive(true);
        }
    }

    public void Input1Pressed()
    {
       if(isInput1on == 0)
        {
            input1.gameObject.SetActive(true);
            PlayerPrefs.SetInt("Input1", 1);
            isInput1on = 1;
        }
        else
        {
            return;
        }
    }

    public void Input2Pressed()
    {
        if(isInput1on == 1)
        {
            if(isInput2on == 0)
            {
                input2.gameObject.SetActive(true);
                PlayerPrefs.SetInt("Input2", 1);
                isInput2on = 1;
            }
            else
            {
                return;
            }
        }
        else
        {
            Debug.Log("1번 먼저 입력!");
            return;
        }
    }

    public void Input3Pressed()
    {
        if(isInput1on == 1)
        {
            if(isInput2on == 1)
            {
                if(isInput3on == 0)
                {
                    input3.gameObject.SetActive(true);
                    PlayerPrefs.SetInt("Input3", 1);
                    isInput3on = 1;
                }
                else
                {
                    return;
                }
            }
            else
            {
                Debug.Log("2번 먼저 입력!");
                return;
            }
        }
        else
        {
            Debug.Log("1번 먼저 입력!");
            return;
        }
    }

    public void Input4Pressed()
    {
        if (isInput1on == 1)
        {
            if (isInput2on == 1)
            {
                if (isInput3on == 1)
                {
                    if (isInput4on == 0)
                    {
                        input4.gameObject.SetActive(true);
                        PlayerPrefs.SetInt("Input4", 1);
                        isInput4on = 1;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    Debug.Log("3번 먼저 입력!");
                    return;
                }
            }
            else
            {
                Debug.Log("2번 먼저 입력!");
                return;
            }
        }
        else
        {
            Debug.Log("1번 먼저 입력!");
            return;
        }
    }

    public void Input5Pressed()
    {
        if (isInput1on == 1)
        {
            if (isInput2on == 1)
            {
                if (isInput3on == 1)
                {
                    if (isInput4on == 1)
                    {
                        if (isInput5on == 0)
                        {
                            input5.gameObject.SetActive(true);
                            PlayerPrefs.SetInt("Input5", 1);
                            isInput5on = 1;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        Debug.Log("4번 먼저 입력!");
                        return;
                    }
                }
                else
                {
                    Debug.Log("3번 먼저 입력!");
                    return;
                }
            }
            else
            {
                Debug.Log("2번 먼저 입력!");
                return;
            }
        }
        else
        {
            Debug.Log("1번 먼저 입력!");
            return;
        }
    }

    public void Input6Pressed()
    {

    }

    public void Input7Pressed()
    {

    }

    public void Input8Pressed()
    {

    }

    public void Input9Pressed()
    {

    }

    public void Input10Pressed()
    {

    }
}
