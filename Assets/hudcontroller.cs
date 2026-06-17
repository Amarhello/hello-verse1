using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class hudcontroller : MonoBehaviour
{
    public Image HpBar;

    

    // Update is called once per frame
    void Update()
    {
        
    }
   public void UptadeHp(int hp)
    {
        HpBar.fillAmount = hp / 100f;
    }
}
