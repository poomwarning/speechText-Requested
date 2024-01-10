using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class POPBT : MonoBehaviour
{
    public RawImage BGNN;
    public Button BTKKB;


    public void Start()
    {
        BGNN.gameObject.SetActive(false);
        BTKKB.gameObject.SetActive(false);

    }

    public void Guidebook()
    {
        BGNN.gameObject.SetActive(true);
        BTKKB.gameObject.SetActive(true);

    }
    
    public void KKBBT()
    {
        BGNN.gameObject.SetActive(false);
        BTKKB.gameObject.SetActive(false);
    }
}
