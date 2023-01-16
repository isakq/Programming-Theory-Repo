using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CombatUI : MonoBehaviour
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
        UIDisplay(robot, playerUI);
        UIDisplay(thief, enemyUI);
    }

    void UIDisplay(Robot robot, TextMeshProUGUI textBox)
    {
        textBox.SetText($"Health: {robot.health}\nDamage: {robot.baseDamage}\nDodge: {robot.dodgeCapability}\nArmor: {robot.armor}");
    }
}
