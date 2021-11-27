using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectFruit : MonoBehaviour
{
    GameObject thisText;
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "appleText":
                GameObject.FindGameObjectWithTag("appleText").GetComponent<Text>().color = Color.gray;
                break;
            case "orangeText":
                GameObject.FindGameObjectWithTag("orangeText").GetComponent<Text>().color = Color.gray;
                break;
            case "lemonText":
                GameObject.FindGameObjectWithTag("lemonText").GetComponent<Text>().color = Color.gray;
                break;
            case "grapeText":
                GameObject.FindGameObjectWithTag("grapeText").GetComponent<Text>().color = Color.gray;
                break;
            case "pumpkinText":
                GameObject.FindGameObjectWithTag("pumpkinText").GetComponent<Text>().color = Color.gray;
                break;
            case "cherryText":
                GameObject.FindGameObjectWithTag("cherryText").GetComponent<Text>().color = Color.gray;
                break;
            default:
                break;
        }
    }
}
