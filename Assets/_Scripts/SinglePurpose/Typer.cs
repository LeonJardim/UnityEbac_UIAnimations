using NaughtyAttributes;
using System.Collections;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Typer : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public float timeBetweenLetters = 0.1f;
    public string phrase;

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = "";
    }

    [Button]
    public void StartTyping()
    {
        if (!EditorApplication.isPlaying) return;
        StartCoroutine(Type(phrase));
    }

    IEnumerator Type(string s)
    {
        textMesh.text = "";
        foreach(char c in s.ToCharArray())
        {
            textMesh.text += c;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }
}
