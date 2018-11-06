using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heroSelect : MonoBehaviour
{
    private GameObject[] CharacterList;
    private int index;

    // Use this for initialization
    void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");

        CharacterList = new GameObject[transform.childCount];

        //Fill array with models
        for (int i = 0; i < transform.childCount; i++)
            CharacterList[i] = transform.GetChild(i).gameObject;

        //Toggle on first render
        foreach (GameObject go in CharacterList)
            go.SetActive(false);

        // toggle on the selected character
        if (CharacterList[index])
            CharacterList[index].SetActive(true);

    }
    public void ToggleLeft(bool isright)
    {
        CharacterList[index].SetActive(false);
        index--;
        if (index < 0)
            index = CharacterList.Length - 1;

        CharacterList[index].SetActive(true);
    }

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene("Game");

    }


    // Update is called once per frame
    void Update()
    {

    }
}
