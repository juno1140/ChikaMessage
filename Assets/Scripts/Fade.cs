using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Fade : MonoBehaviour
{
    [SerializeField] private float speed = 0.01f;
    [SerializeField] GameObject panel;
    [SerializeField] private Text message;
    private float red, green, blue;
    private float alfa;
    private bool fadeInCheck = false;
    private bool fadeOutCheck = false;

    // Start is called before the first frame update
    void Start()
    {
        //message.text = "";
        panel.SetActive(false);
        alfa = 0;
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
        GetComponent<Image>().color = new Color(red, green, blue, alfa);
    }

    private void Update()
    {
        if (fadeInCheck)
        {
            FadeIn();
        }
        if (fadeOutCheck)
        {
            FadeOut();
        }
    }

    public void FadeInStart()
    {
        fadeInCheck = true;
    }

    public void FadeOutStart()
    {
        fadeOutCheck = true;
    }

    private void FadeIn()
    {
        if (alfa < 1)
        {
            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa += speed;
        }
        else
        {
            StartCoroutine("TextChange");
            fadeInCheck = false;
        }
    }

    private void FadeOut()
    {
        if (alfa > 0)
        {
            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa -= speed;
        }
        else
        {
            fadeOutCheck = false;
        }
    }

    IEnumerator TextChange()
    {

        yield return new WaitForSeconds(2f);

        panel.SetActive(true);
        message.text = "一番大切なのはできるかどうかじゃない";

        yield return new WaitForSeconds(3f);

        message.text = "やりたいかどうかだよ";

        yield return new WaitForSeconds(3f);

        panel.SetActive(false);
        message.text = "";
        fadeOutCheck = true;

    }
}
