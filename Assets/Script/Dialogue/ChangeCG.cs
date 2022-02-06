using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class ChangeCG : MonoBehaviour
{
    public GameObject Normal_CG;
    public GameObject Happy_CG;
    public GameObject Angry_CG;
    public GameObject Sad_CG;

    string currentMood = "Normal";

    [YarnCommand("ChangeCG")]
    public void CreateQuest(string mood)
    {
        StartCoroutine(FadeOut(currentMood));
   
        switch (mood)
        {
            case "Normal":
                Normal_CG.SetActive(true);
                //StopAllCoroutines();
                currentMood = "Normal";

                break;

            case "Happy":
                Happy_CG.SetActive(true);
                //StopAllCoroutines();
                currentMood = "Happy";

                break;
            case "Angry":
                Angry_CG.SetActive(true);
                //StopAllCoroutines();
                currentMood = "Angry";


                break;
            case "Sad":
                Sad_CG.SetActive(true);
                //StopAllCoroutines();
                currentMood = "Sad";


                break;
            default:
                break;

        }
    }

    IEnumerator FadeOut(string mood)
    {
        switch (mood)
        {
            case "Normal":
                Normal_CG.GetComponent<Animator>().SetTrigger("FadeOut");
                yield return new WaitForSeconds(0.2f);
                Normal_CG.SetActive(false);
                break;

            case "Happy":
                Happy_CG.GetComponent<Animator>().SetTrigger("FadeOut");
                yield return new WaitForSeconds(0.2f);
                Happy_CG.SetActive(false);
                break;

            case "Angry":
                Angry_CG.GetComponent<Animator>().SetTrigger("FadeOut");
                yield return new WaitForSeconds(0.2f);
                Angry_CG.SetActive(false);
                break;
            case "Sad":
                Sad_CG.GetComponent<Animator>().SetTrigger("FadeOut");
                yield return new WaitForSeconds(0.2f);
                Sad_CG.SetActive(false);
                break;
            default:
                break;

        }


    }


 }
