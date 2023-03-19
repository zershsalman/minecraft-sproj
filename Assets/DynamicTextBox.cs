using UnityEngine;
using UnityEngine.UI;

public class DynamicTextBox : MonoBehaviour
{
    public RectTransform panelRectTransform;
    public Text text;

    void Update()
    {
        // Get the preferred height of the text
        float preferredHeight = LayoutUtility.GetPreferredHeight(text.rectTransform);

        // Set the new height of the panel
        Vector2 panelSize = panelRectTransform.sizeDelta;
        panelRectTransform.sizeDelta = new Vector2(panelSize.x, preferredHeight);

        // Adjust the position of the text object to center it in the panel
        Vector2 textSize = text.rectTransform.sizeDelta;
        text.rectTransform.anchoredPosition = new Vector2(0, -((panelSize.y - textSize.y) / 2));
    }
}
