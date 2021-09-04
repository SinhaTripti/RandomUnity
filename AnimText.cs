using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnimText : MonoBehaviour
{
    public Text textArea;
    public string[] strings;
    public float speed = 0.1f;

    int stringIndex = 0;
    int characterIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void StartPanel()
    {
        StartCoroutine(DisplayTimer()); 
    }
    

    IEnumerator DisplayTimer()
    {
        while (1 == 1)
        {
            yield return new WaitForSeconds(speed);
            if (characterIndex > strings[stringIndex].Length)
            {
                continue;
            }
            textArea.text = strings[stringIndex].Substring(0, characterIndex);
            characterIndex++;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
