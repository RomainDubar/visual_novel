using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DS.Engine
{
    using Data;

    public class DialogManager : MonoBehaviour
    {
        [Header("Container")]
        [SerializeField] private DSContainerSO container;
        [Header("Text")]
#if TMP
        [SerializeField] private TMPro.TextMeshProUGUI textDialog;
        [SerializeField] private TMPro.TextMeshProUGUI textCharacterName;
#else
    [SerializeField] private Text textDialog;
    [SerializeField] private Text textCharacterName;
#endif
        [Header("Images")]
        [SerializeField] private Image imageCharacter;
        [SerializeField] private Image imageCharacter2;
        [SerializeField] private Image imageBackground;
        [SerializeField] private Image imageDialogue;
        [SerializeField] private Image leftCharacterMask;
        [SerializeField] private Image rightCharacterMask;
        [Header("Buttons")]
        [SerializeField] private GameObject buttonParent;
        [SerializeField] private GameObject buttonPrefab;

        private Dictionary<string, DSNodeData> dialogues = new Dictionary<string, DSNodeData>();
        private DSNodeData currentDialogue;

        private void Awake()
        {
            foreach (DSNodeData dialogue in container.Nodes)
            {
                dialogues.Add(dialogue.Id, dialogue);
            }
            currentDialogue = container.FirstNode;
        }

        private void Start()
        {
            UpdateDialogSequence(currentDialogue);
        }

        private void UpdateDialogSequence(int index)
        {
            if (index >= currentDialogue.Choices.Count) return;
            UpdateDialogSequence(dialogues[currentDialogue.Choices[index].NextDialogueID]);
        }

        public void UpdateDialogSequence(DSNodeData dialogue)
        {
            UpdateTexts(dialogue);
            UpdateChoices(dialogue);
            UpdateSprites(dialogue);
            currentDialogue = dialogue;
            rightCharacterMask.enabled = dialogue.LeftChar;
            leftCharacterMask.enabled = !dialogue.LeftChar;
        }

        private void UpdateTexts(DSNodeData dialogue)
        {
            if (!string.IsNullOrEmpty(dialogue.Text))
            {
                textDialog.transform.parent.gameObject.SetActive(true);
                textDialog.text = dialogue.Text;
                textCharacterName.transform.parent.gameObject.SetActive(true);
                textCharacterName.text = dialogue.CharacterName;
            }
            else
            {
                textDialog.transform.parent.gameObject.SetActive(false);
                textCharacterName.transform.parent.gameObject.SetActive(false);
            }
        }

        private void UpdateChoices(DSNodeData dialogue)
        {
            List<DSChoiceData> validChoices = new List<DSChoiceData>();
            foreach (DSChoiceData choice in dialogue.Choices)
            {
                if (!string.IsNullOrEmpty(choice.NextDialogueID)) validChoices.Add(choice);
            }
            HandleButtons(validChoices, dialogue.Choices);
        }

        private void HandleButtons(List<DSChoiceData> validChoices, List<DSChoiceData> allChoices)
        {

            Button[] children = buttonParent.GetComponentsInChildren<Button>();
            foreach (Button child in children) GameObject.Destroy(child.gameObject);

            List<(Button button, int index)> buttons = new List<(Button button, int index)>();
            for (int i = 0; i < validChoices.Count; i++)
            {
                int index = allChoices.IndexOf(validChoices[i]);
                GameObject go = GameObject.Instantiate(buttonPrefab, buttonParent.transform);
                Button button = go.GetComponent<Button>();
#if TMP
                TMPro.TextMeshProUGUI text = go.GetComponentInChildren<TMPro.TextMeshProUGUI>();
#else
                Text text = go.GetComponentInChildren<Text>();
#endif
                text.text = validChoices[i].Name;
                buttons.Add((button, index));
            }

            foreach ((Button button, int index) button in buttons)
            {
                button.button.onClick.RemoveAllListeners();
                button.button.onClick.AddListener(() => UpdateDialogSequence(button.index));
            }
        }

        private void UpdateSprites(DSNodeData dialogue)
        {
            if (dialogue.CharacterSprite != null) imageCharacter.sprite = dialogue.CharacterSprite;
            if (dialogue.Character2Sprite != null) imageCharacter2.sprite = dialogue.Character2Sprite;
            if (dialogue.BackgroundSprite != null) imageBackground.sprite = dialogue.BackgroundSprite;
            if (dialogue.DialogueSprite != null) imageDialogue.sprite = dialogue.DialogueSprite;
        }
    }
}