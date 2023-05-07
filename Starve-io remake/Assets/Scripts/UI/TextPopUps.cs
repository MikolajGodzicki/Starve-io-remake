using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextPopUps : MonoBehaviour
{
    public static TextPopUps Instance;

    public GameObject TextPopUpPrefab;
    public Transform CanvasTransform;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    public void PopUpText(string text) {
        GameObject textPopUp = Instantiate(TextPopUpPrefab);

        textPopUp.transform.SetParent(CanvasTransform);
        textPopUp.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 380f);
        textPopUp.GetComponent<TextMeshProUGUI>().text = text;
    }
}
