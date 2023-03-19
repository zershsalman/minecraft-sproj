/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scene2choices : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject choice1;
    public GameObject choice2;
    public GameObject choice3;
    public GameObject choice4;
    public GameObject choice5;
    public GameObject choice6;
    // public GameObject panel = new GameObject("Panel");
    public int choiceMade;

    public void ChoiceOption1()
    {
        
        TextBox.GetComponent<Text>().text = "Well done! Your thinking pattern is the way it should be in such situations. Getting bullied will never be your fault. No one deserves to be bullied and it is always the bully's problem that leads to bullying. You should not blame myself for the bully's actions. A troubled individual or a group of troubled people cannot determine how you feel about yourself. You should not indulge in negative self talk and should always remember your positive strengths and qualities.";
        choiceMade = 1;
        
    }
    
    public void ChoiceOption2()
    {
        
        TextBox.GetComponent<Text>().text = "Well done! Your thinking pattern is the way it should be in such situations. You don't have to indulge in self doubt. You can reach out for help if you are being bullied. You don't have to face the situation alone, and there are people who can support you and provide guidance, such as your friends.";
        choiceMade = 2;
        
    }

    public void ChoiceOption3()
    {
        
        TextBox.GetComponent<Text>().text = "Well done! Your thinking pattern is the way it should be in such situations. You should critically evaluate the situation and, if it is possible,  you should stand up to the bully and set boundaries that can help reduce the bullying behavior. However, it's important to prioritize your safety first and seek help if necessary.";
        choiceMade = 3;
        
    }
    public void ChoiceOption4()
    {
        
        TextBox.GetComponent<Text>().text = "You should not blame yourself for being bullied. Thinking that the bully is saying true stuff is not true. You should realize that no one deserves to get bullied and you can always take an action against it one way or another. Here are some of the healthy ways you should think about this situation.";
        choiceMade = 4;
        
    }
    public void ChoiceOption5()
    {
        
        TextBox.GetComponent<Text>().text = " Just because someone bullied you, does not necessarily mean you have to be suspicious of everyone else. There will always be good people around you whom you can trust and confide in. Thus, socially limiting your interactions will never be a permanent solution. Here are some of the healthy ways you should think about this situation. ";
        choiceMade = 5;
        
    }
    public void ChoiceOption6()
    {
        
        TextBox.GetComponent<Text>().text = " Making someone go through what you went through is never a good solution.  You should not plan revenge and instead look for alternatives to handle the situation. Here are some of the healthy ways you should think about this situation. ";
        choiceMade = 6;
        
    }
    void Update()
    {
        if (choiceMade >= 1)
        {
            choice1.SetActive (false);
            choice2.SetActive (false);
            choice3.SetActive (false);
            choice4.SetActive (false);
            choice5.SetActive (false);
            choice6.SetActive (false);
            // panel.GetComponent(RectTransform).sizeDelta = new Vector2 (760, 280);

        }
    }
}
*/