using UnityContrib.UnityEngine;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class InputController : MonoBehaviour
{
    [SerializeField]
    private BaseSelector characterSelector;

    private void Awake()
    {
        this.characterSelector.DisableIfNull(this.characterSelector, "characterSelector");
    }

    private void Update()
    {
        var characterTransform = this.characterSelector.Selected;
        if (characterTransform == null)
        {
            Debug.LogWarning("No character selected.");
            return;
        }

        var character = characterTransform.GetComponent<ThirdPersonCharacter>();
        if (character == null)
        {
            Debug.LogWarning("Selected character does not have a ThirdPersonChatacter component.");
            return;
        }

        var jump = Input.GetButtonDown("Jump");
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        var crouch = Input.GetKeyDown(KeyCode.C);
        var isWalking = Input.GetKey(KeyCode.LeftShift);

        var move = characterTransform.forward * v + characterTransform.right * h;
        if (isWalking)
        {
            move *= 0.5f;
        }

        character.Move(move, crouch, jump);
    }
}
