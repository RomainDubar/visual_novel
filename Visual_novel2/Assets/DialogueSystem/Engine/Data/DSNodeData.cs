using System;
using System.Collections.Generic;
using UnityEngine;

namespace DS.Engine.Data {
    [Serializable]
    public class DSNodeData {
        public string Id { get => id; set => id = value; }
        public string CharacterName { get => characterName; set => characterName = value; }
        public string Text { get => text; set => text = value; }
        public List<DSChoiceData> Choices { get => choices; set => choices = value; }
        public Sprite CharacterSprite { get => characterSprite; set => characterSprite = value; }
        public Sprite Character2Sprite { get => character2Sprite; set => character2Sprite = value; }
        public Sprite BackgroundSprite { get => backgroundSprite; set => backgroundSprite = value; }
        public Sprite DialogueSprite { get => dialogueSprite; set => dialogueSprite = value; }
        public Vector2 Position { get => position; set => position = value; }
        public bool LeftChar { get => leftChar; set => leftChar = value; }
        

        [SerializeField] private string id;
        [SerializeField] private string characterName, text;
        [SerializeField] private List<DSChoiceData> choices;
        [SerializeField] private Sprite characterSprite, character2Sprite, backgroundSprite, dialogueSprite;
        [SerializeField] private Vector2 position;
        [SerializeField] private bool leftChar;

        public DSNodeData() {
            id = Guid.NewGuid().ToString();
            characterName = "Character";
            text = "Text...";
            choices = new List<DSChoiceData>();
            characterSprite = null;
            character2Sprite = null;
            backgroundSprite = null;
            dialogueSprite = null;
            position = Vector3.zero;
            leftChar = false;
                    }

        public DSNodeData(DSNodeData data) {
            id = data.Id;
            characterName = data.CharacterName;
            text = data.Text;
            choices = Clone(data.Choices);
            characterSprite = data.CharacterSprite;
            character2Sprite = data.Character2Sprite;
            backgroundSprite = data.BackgroundSprite;
            dialogueSprite = data.DialogueSprite;
            position = new Vector2(data.Position.x, data.Position.y);
            leftChar = data.LeftChar;
            
        }



        private List<DSChoiceData> Clone(List<DSChoiceData> choices) {
            List<DSChoiceData> clone = new List<DSChoiceData>();
            foreach(DSChoiceData choice in choices) {
                clone.Add(new DSChoiceData(choice));
            }
            return clone;
        }
    }
}
