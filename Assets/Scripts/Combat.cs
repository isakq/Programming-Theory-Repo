using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public Robot robot;
    public Thief thief;

    public TextMeshProUGUI playerUI;
    public TextMeshProUGUI enemyUI;
    // Start is called before the first frame update
    void Start()
    {
        robot = FindObjectOfType<Robot>().GetComponent<Robot>();
        thief = FindObjectOfType<Thief>().GetComponent<Thief>();
    }

    // Update is called once per frame
    void Update()
    {
        UIDisplay();
    }

    void UIDisplay()
    {
        playerUI.SetText($"Health: {robot.standardHealth}\nDamage: {robot.standardBaseDamage}\nDodge: {robot.standardDodgeCapability}\nArmor: {robot.standardArmor}");
        enemyUI.SetText($"Health: {thief.thiefHealth}\nDamage: {thief.thiefBaseDamage}\nDodge: {thief.thiefDodgeCapability}\nArmor: {thief.thiefArmor}");
    }

}
