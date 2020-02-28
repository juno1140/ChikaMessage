using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] private Text text;

    public void TextChange()
    {
        Debug.Log("OK");
        StartCoroutine("Change");
    }

    IEnumerator Change()
    {
        
        text.text = "";

        yield return new WaitForSeconds(3f);

        text.text = "一番大切なのはできるかどうかじゃない";

        yield return new WaitForSeconds(2f);

        text.text = "やりたいかどうかだよ";

        yield return new WaitForSeconds(2f);

    }
}