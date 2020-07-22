using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomButton : MonoBehaviour
{
    public GameObject imageBig;
    public GameObject imageSmall;
    public GameObject text;

    public void Selected(){
        SceneManager.Instance.mainImage.sprite = imageBig.GetComponent<Image>().sprite;
        SceneManager.Instance.DisableAllButtons();
        this.GetComponent<Image>().sprite = SceneManager.Instance.selectedImage;
        imageBig.SetActive(true);
        imageSmall.SetActive(false);
        text.SetActive(true);
    }

    public void Unselected(){
        this.GetComponent<Image>().sprite = SceneManager.Instance.idleImage;
        imageBig.SetActive(false);
        imageSmall.SetActive(true);
        text.SetActive(false);
    }

}
