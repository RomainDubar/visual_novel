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
        public Sprite BackgroundSprite { get => backgroundSprite; set => backgroundSprite = value; }
        public Vector2 Position { get => position; set => position = value; }

        [SerializeField] private string id;
        [SerializeField] private string characterName, text;
        [SerializeField] private List<DSChoiceData> choices;
        [SerializeField] private Sprite characterSprite, backgroundSprite;
        [SerializeField] private Vector2 position;

        public DSNodeData() {
            id = Guid.NewGuid().ToString();
            characterName = "Character";
            text = "Text...";
            choices = new List<DSChoiceData>();
            characterSprite = null;
            backgroundSprite = null;
            position = Vector3.zero;
        }

        public DSNodeData(DSNodeData data) {
            id = data.Id;
            characterName = data.CharacterName;
            text = data.Text;
            choices = Clone(data.Choices);
            characterSprite = data.CharacterSprite;
            backgroundSprite = data.BackgroundSprite;
            position = new Vector2(data.Position.x, data.Position.y);
        }

        public DSNodeData(string id, string characterName, string text, List<DSChoiceData> choices, Sprite characterSprite, Sprite backgroundSprite, Vector2 position) {
            this.id = id;
            this.characterName = characterName;
            this.text = text;
            this.choices = choices;
            this.characterSprite = characterSprite;
            this.backgroundSprite = backgroundSprite;
            this.position = position;
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
