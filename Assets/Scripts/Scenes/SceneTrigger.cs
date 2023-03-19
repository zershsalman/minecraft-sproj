using Unity.VisualScripting;
using UnityEngine;
using Yarn.Unity;

public class SceneTrigger : MonoBehaviour
{
    private enum SceneNumber
    {
        SceneOne,SceneTwo,SceneThree,SceneFour,SceneFive,SceneSix,SceneSeven,SceneEight
    }

    [SerializeField] private GameObject skipButton;
    [SerializeField] private SceneNumber sceneNumber;


    private DialogueRunner _dialogueRunner;
    private SceneDialogueHandler dialogueHandler;
    [SerializeField] private OptionView optionsListMenu;
    private ScenariosButton _scenariosButton;

    private void Awake()
    {
        _dialogueRunner = FindObjectOfType<DialogueRunner>();
        dialogueHandler = FindObjectOfType<SceneDialogueHandler>();
        optionsListMenu = FindObjectOfType<OptionView>();
        _scenariosButton = FindObjectOfType<ScenariosButton>();
    }

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // if player enters
        {
            _scenariosButton.gameObject.SetActive(false);
            foreach (var OptionView in FindObjectsOfType<OptionView>())
            {
                OptionView.gameObject.SetActive(false);
            }
            skipButton.SetActive(true);
            dialogueHandler.DisablePlayerMovement();
            _dialogueRunner.transform.parent.gameObject.SetActive(true);
            _dialogueRunner.Stop();
            switch (sceneNumber)
            {
                case SceneNumber.SceneOne:
                    _dialogueRunner.StartDialogue("SceneOne");
                    break;
                case SceneNumber.SceneTwo:
                    _dialogueRunner.StartDialogue("SceneTwo");
                    break;
                case SceneNumber.SceneThree:
                    _dialogueRunner.StartDialogue("SceneThree");
                    break;
                case SceneNumber.SceneFour:
                    _dialogueRunner.StartDialogue("SceneFour");
                    break;
                case SceneNumber.SceneFive:
                    _dialogueRunner.StartDialogue("SceneFive");
                    break;
                case SceneNumber.SceneSix:
                    _dialogueRunner.StartDialogue("SceneSix");
                    break;
                case SceneNumber.SceneSeven:
                    _dialogueRunner.StartDialogue("SceneSeven");
                    break;
                case SceneNumber.SceneEight:
                    _dialogueRunner.StartDialogue("SceneEight");
                    break;
            }
        }
    }

   
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueHandler.DisableDialogue();
            _scenariosButton.gameObject.SetActive(true);
        }
    }
}
