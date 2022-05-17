using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SendLabel : MonoBehaviour
{
    public GameObject id;
    public string min;
    public string sec;
    public string label;

    private string Id;

    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLScfhOJOejRC4v4V6Tvbf76VBNGMoh14vGy9JkSPpxo7yPUJlQ/formResponse";

    IEnumerator Post(string id, string min, string sec, string label)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.186503657", id);
        form.AddField("entry.2138931093", min);
        form.AddField("entry.184676958", sec);
        form.AddField("entry.1397298874", label);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;
    }

    public void Send()
    {
        Id = id.GetComponentInChildren<TMP_InputField>().text;
        StartCoroutine(Post(Id, min, sec, label));
    }
}
