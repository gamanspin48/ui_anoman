using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{   
   public Image mainImage;
   public Button[] buttons;
   public static SceneManager Instance { get; private set; } // static singleton
   void Awake() {
         if (Instance == null) { Instance = this;  }
         else { Destroy(gameObject); }
         // Cache references to all desired variables
     }
    // Start is called before the first frame update
    public void DisableAllButtons(){
        foreach (Button button in buttons)
        {
            button.GetComponent<CustomButton>().Unselected();
        }
    }
}
