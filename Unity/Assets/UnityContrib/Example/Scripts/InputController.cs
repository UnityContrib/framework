using UnityContrib.UnityEngine;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

/// <summary>
/// Input controller for the player.
/// </summary>
public class InputController : MonoBehaviour
{
#pragma warning disable 0649 // Field 'XYZ' is never assigned to, and will always have it's default value null

    /// <summary>
    /// The selector to use to find the character.
    /// </summary>
    [SerializeField]
    [Tooltip("The selector to use to find the character.")]
    private BaseSelector characterSelector;

#pragma warning restore 0649 // Field 'XYZ' is never assigned to, and will always have it's default value null

    /// <summary>
    /// Disables the component if dependencies are not available.
    /// </summary>
    private void Awake()
    {
        this.characterSelector.DisableIfNull(this.characterSelector, "characterSelector");
    }

    /// <summary>
    /// Reads the input and sends it to the <see cref="ThirdPersonCharacter"/>.
    /// </summary>
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
