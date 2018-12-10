﻿using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerSpawnPosition = new Vector3(0, 1, -7);
    public Character[] characters;

    public GameObject characterSelectPanel;
    public GameObject abilityPanel;

    public void OnCharacterSelect(int characterChoice)
    {
        characterSelectPanel.SetActive(false);
        abilityPanel.SetActive(true);
        GameObject spawnedPlayer = Instantiate(player, playerSpawnPosition, Quaternion.identity) as GameObject;
        WeaponMarker weaponMarker = spawnedPlayer.GetComponentInChildren<WeaponMarker>();
        AbilityCoolDown[] coolDownButtons = GetComponentsInChildren<AbilityCoolDown>();
        Character selectedCharacter = characters[characterChoice];
        for (int i = 0; i < coolDownButtons.Length; i++)
        {
            coolDownButtons[i].Initialize(selectedCharacter.characterAbilities[i], weaponMarker.gameObject);
        }
    }
}