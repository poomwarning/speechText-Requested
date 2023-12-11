using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SearchANM : MonoBehaviour
{
    private Animator anim;
    public InputField inputText;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("Start");
    }

   
    public void ModelSwitch()
    {
        string cleanedInput = inputText.text.Trim().ToLowerInvariant();

        switch (cleanedInput)
        {
            // 1. Greetings
            case "สวัสดี":
            case "สวัสดีครับ":
            case "สวัสดีค่ะ":
            case "สวัสดีจ้า":
                SetAnimationTrigger("Hello");
                break;

            case "ขอบคุณ":
            case "ขอบคุณครับ":
            case "ขอบคุณค่ะ":
            case "ขอบคุณจ้า":
                SetAnimationTrigger("ThankYou");
                break;

            case "ขอโทษ":
            case "ขอโทษครับ":
            case "ขอโทษค่ะ":
            case "ขอโทษจ้า":
                SetAnimationTrigger("Sorry");
                break;

            case "ไม่สบายใจ":
            case "ไม่สบายใจครับ":
            case "ไม่สบายใจค่ะ":
                SetAnimationTrigger("NotHappy");
                break;

            case "ไม่สบาย":
            case "ไม่สบายครับ":
            case "ไม่สบายค่ะ":
            case "ป่วย":
                SetAnimationTrigger("Sick");
                break;

            case "ใช่":
                SetAnimationTrigger("Yes");
                break;

            case "ไม่ใช่":
                SetAnimationTrigger("No");
                break;

            case "พบกันใหม่":
                SetAnimationTrigger("SeeYouAgain");
                break;

            case "โชคดี":
                SetAnimationTrigger("GoodLuck");
                break;

            case "ไม่เป็นไร":
                SetAnimationTrigger("YoureWelcome");
                break;

            
            // Add more cases for other numbers...

            default:
                // Handle cases where the input doesn't match any trigger
                break;
        }
    }

    private void SetAnimationTrigger(string triggerName)
    {
        anim.SetTrigger(triggerName);
    }
}
