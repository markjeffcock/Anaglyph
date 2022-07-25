using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourSwitch : MonoBehaviour
{
    public GameObject[] leftSphere = new GameObject[3];
    public GameObject[] rightSphere = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        rightSphere[0].SetActive(true);
        rightSphere[1].SetActive(false);
        rightSphere[2].SetActive(false);
        leftSphere[0].SetActive(true);
        leftSphere[1].SetActive(false);
        leftSphere[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void choosePair(int pairChosen)
    {
        if (pairChosen == 1)
        {
            rightSphere[0].SetActive(true);
            rightSphere[1].SetActive(false);
            rightSphere[2].SetActive(false);
            leftSphere[0].SetActive(true);
            leftSphere[1].SetActive(false);
            leftSphere[2].SetActive(false);
        }
        if (pairChosen == 2)
        {
            rightSphere[0].SetActive(false);
            rightSphere[1].SetActive(true);
            rightSphere[2].SetActive(false);
            leftSphere[0].SetActive(false);
            leftSphere[1].SetActive(true);
            leftSphere[2].SetActive(false);
        }
        if (pairChosen == 3)
        {
            rightSphere[0].SetActive(false);
            rightSphere[1].SetActive(false);
            rightSphere[2].SetActive(true);
            leftSphere[0].SetActive(false);
            leftSphere[1].SetActive(false);
            leftSphere[2].SetActive(true);
        }

    }
}
