using UnityEngine;
using Yarn.Unity;

public class SceneDialogueHandler : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private MouseLook _playerLook;
    private DialogueRunner _dialogueRunner;
    private ScenariosButton _scenariosButton;
    [SerializeField] private GameObject skipButton;
    [SerializeField] private KeyCode nextDialogueButton;

    private void Awake()
    {
        _scenariosButton = FindObjectOfType<ScenariosButton>();
        _playerMovement = FindObjectOfType<PlayerMovement>();
        _playerLook = FindObjectOfType<MouseLook>();
        _dialogueRunner = FindObjectOfType<DialogueRunner>();
        _dialogueRunner.AddCommandHandler("enablePlayerMovement", EnablePlayerMovement);
        _dialogueRunner.AddCommandHandler("disableDialogue", DisableDialogue);
        _dialogueRunner.AddCommandHandler("disableSkipButton", DisableSkipButton);
        _dialogueRunner.AddCommandHandler("enableSkipButton", EnableSkipButton);
        _dialogueRunner.AddCommandHandler("cleanOptionsView", CleanOptionsView);

    }
    /*private void Update()
    {
        if (Input.GetKeyDown(nextDialogueButton))
        {
            _dialogueRunner.dialogueViews[0].UserRequestedViewAdvancement();
        }
    }*/
    public void EnablePlayerMovement()
    {
        _playerMovement.enabled = true;
        _playerLook.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void DisablePlayerMovement()
    {
        _playerMovement.enabled = false;
        _playerLook.enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }

    public void DisableDialogue()
    {
        _scenariosButton.gameObject.SetActive(false);
           CleanOptionsView();
        EnablePlayerMovement();
        if (!_dialogueRunner.IsDialogueRunning) return;
            _dialogueRunner.dialogueViews[1].DismissLine(() =>
            {
                Debug.Log("Stopping dialogue");
                _dialogueRunner.Stop();
                Debug.Log("Dialogue Stopped");
                _dialogueRunner.StartDialogue("Exit");
            });
           
    }

public void CleanOptionsView()
{
foreach (var OptionView in FindObjectsOfType<OptionView>()){
                        OptionView.gameObject.SetActive(false);
                    }
}
    public void DisableSkipButton()
    {
        skipButton.SetActive(false);
    }

    public void EnableSkipButton()
    {
        skipButton.gameObject.SetActive(true);
    }

}
