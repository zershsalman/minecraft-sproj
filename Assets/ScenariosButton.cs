using UnityEngine;

public class ScenariosButton : MonoBehaviour
{
    [SerializeField] private bool isButtonPressed = false;
    
    public GameObject scenariosPanel;
    public KeyCode openKey = KeyCode.P;
    public Transform[] teleportPositions; // Array of teleport positions
    
    private PlayerMovement _playerMovement;
    private MouseLook _playerLook;

        void Start()
        {
            _playerMovement = FindObjectOfType<PlayerMovement>();
            _playerLook = FindObjectOfType<MouseLook>();
        }

    void Update()
    {
    
        if (Input.GetKeyDown(openKey))
        {
            scenariosPanel.SetActive(!scenariosPanel.activeSelf);
            isButtonPressed =  !isButtonPressed;
        }

        if(!isButtonPressed) return;
            for (int i = 0; i < teleportPositions.Length; i++)
        {
            if (Input.GetKeyDown((i + 1).ToString()))
            {
                TeleportPlayer(i);
            }
        }
    }

    private void TeleportPlayer(int index)
    {
        // Replace "player" with the name of your player object
        _playerMovement.enabled = false;
        _playerLook.enabled = false;
        GameObject player = _playerMovement.gameObject;
        player.transform.position = teleportPositions[index].position;
        player.transform.rotation = teleportPositions[index].rotation;
        scenariosPanel.SetActive(false);
        isButtonPressed =  false;
        Invoke(nameof(EnablePlayerMovement), 0.1f);
        
    }

    private void EnablePlayerMovement()
    {
        _playerMovement.enabled = true;
        _playerLook.enabled = true;
    }
}