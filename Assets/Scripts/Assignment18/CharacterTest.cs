using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        Character[] characters;

        void Start()
        {
            characters = new Character[2];
            characters[0] = new Officer("Ahmad", 150, new Position(1, 0, 1));
            characters[1] = new Soldier("jamal", 80, new Position(-1, 0, 1));

            foreach (Character character in characters)
            {
                character.DisplayInfo();
            }

            Debug.Log("Soldier health before the attack : " + characters[1].Health);
            characters[0].Attack(50, characters[1]);
            Debug.Log("Soldier health after the attack : " + characters[1].Health);

        }
    }
}
