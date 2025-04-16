using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    List<Transform> panels;
    // Start is called before the first frame update
    void Start()
    {
        panels = new List<Transform>();
        foreach (Transform child in transform)
        {
            panels.Add(child);
        }
        panels[1].gameObject.SetActive(false);
        panels[2].gameObject.SetActive(false);
    }
    public void GoTo(int panelIndex)
    {

        for (int i = 0; i < panels.Count; i++)
        {
            if (i == panelIndex)
            {
                panels[i].gameObject.SetActive(true);
            }
            else
            {
                panels[i].gameObject.SetActive(false);
            }
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
