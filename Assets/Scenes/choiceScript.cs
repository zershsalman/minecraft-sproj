using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choiceScript : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject choice1;
    public GameObject choice2;
    public GameObject choice3;
    public GameObject choice4;
    public GameObject choice5;
    public int choiceMade;

    public void ChoiceOPtion1()
    {
        
        TextBox.GetComponent<Text>().text = "Well done! Your thinking pattern is the way it should be in such situations. You should let your emotions cool down. You should not react immediately and take any harsh decisions such as ending a friendship. You might feel differently about the situation if you give yourself some time to think. ";
        choiceMade = 1;
        // Debug.Log("Hre");
    }
    public void ChoiceOPtion2()
    {
        TextBox.GetComponent<Text>().text = "Well done! Your thinking pattern is the way it should be in such situations. At an appropriate time, you should confront your friend about why they did, what they did. Then, base your decision on their explanation. Even if they are in the wrong, you can choose to forgive them. Forgiveness does not mean forgetting or condoning the behavior, but it does mean letting go of the negative emotions and moving forward. Forgiving your friend can help you to heal and move on.";
        choiceMade = 2;
    }
        public void ChoiceOPtion3()
    {
        TextBox.GetComponent<Text>().text = "It seems like you are thinking about this situation in an unhealthy way. Maybe consider not reacting immediately, or consider forgiving them for what they did.";
        choiceMade = 3;
    }
        public void ChoiceOPtion4()
    {
        TextBox.GetComponent<Text>().text = "It seems like you are thinking about this situation in an unhealthy way. Maybe consider not reacting immediately, or consider forgiving them for what they did.";
        choiceMade = 4;
    }
        public void ChoiceOPtion5()
    {
        TextBox.GetComponent<Text>().text = "It seems like you are thinking about this situation in an unhealthy way. Maybe consider not reacting immediately, or consider forgiving them for what they did.";
        choiceMade = 5;
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
        }
    }
}
 