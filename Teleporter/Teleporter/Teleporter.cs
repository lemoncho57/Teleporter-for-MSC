using MSCLoader;
using System.Configuration;
using HutongGames.PlayMaker.Actions;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Teleporter
{
    public class Teleporter : Mod
    {
        public override string ID => "Teleporter"; // Your (unique) mod ID 
        public override string Name => "Teleporter"; // Your mod name
        public override string Author => "Lemoncho57"; // Name of the Author (your name)
        public override string Version => "1.0"; // Version
        public override string Description => "This mod allows you to teleport to different locations"; // Short description of your mod

        public Keybind showGUIKey;
        public bool showGUI;
        public GameObject player;
        public GameObject settingsMenu;

        private GUIStyle styleAligment;


        // Buttons
        public bool buttonHome;
        public bool buttonStore;
        public bool buttonAppartments;
        public bool buttonCottage;
        public bool buttonDance;
        public bool buttonDrag;
        public bool buttonInspection;
        public bool buttonJouko;
        public bool buttonLandfill;
        public bool buttonRepairShop;
        public bool buttonSewage;
        public bool buttonGrandma;
        public bool buttonSkiHill;
        public bool buttonStrawberry;
        public bool buttonSuski;
        public bool buttonTeimoHouse;
        public bool buttonFarm;
        public bool buttonVentti;


        public float hierachyWidth;

        
        public override void ModSetup()
        {
            SetupFunction(Setup.OnLoad, Mod_OnLoad);
            SetupFunction(Setup.OnGUI, Mod_OnGUI);
            SetupFunction(Setup.Update, Mod_Update);
            SetupFunction(Setup.ModSettings, Mod_Settings);
        }

        private void Mod_Settings()
        {
            showGUIKey = Keybind.Add(this, "keybindopenmenu", "Open Teleport Menu", KeyCode.Slash);
        }


        private void Mod_OnLoad()
        {
            styleAligment.alignment = TextAnchor.UpperCenter;
        }
        private void Mod_OnGUI()
        {
            if (showGUI)
            {

                GUI.Box(new Rect(510, 0, 500, 825), "Teleporter");

                buttonHome = GUI.Button(new Rect(610, 25, 200, 30), "Home");
                buttonStore = GUI.Button(new Rect(610, 65, 200, 30), "Store");
                buttonAppartments = GUI.Button(new Rect(610, 105, 200, 30), "Appartments");
                buttonCottage = GUI.Button(new Rect(610, 145, 200, 30), "Cottage");
                buttonDance = GUI.Button(new Rect(610, 185, 200, 30), "Dance");
                buttonDrag = GUI.Button(new Rect(610, 225, 200, 30), "Drag");
                buttonInspection = GUI.Button(new Rect(610, 265, 200, 30), "Inspection");
                buttonJouko = GUI.Button(new Rect(610, 305, 200, 30), "Jouko");
                buttonLandfill = GUI.Button(new Rect(610, 345, 200, 30), "Landfill");
                buttonRepairShop = GUI.Button(new Rect(610, 385, 200, 30), "Repair Shop");
                buttonSewage = GUI.Button(new Rect(610, 425, 200, 30), "Sewage");
                buttonGrandma = GUI.Button(new Rect(610, 465, 200, 30), "Grandma");
                buttonSkiHill = GUI.Button(new Rect(610, 505, 200, 30), "Ski Hill");
                buttonStrawberry = GUI.Button(new Rect(610, 545, 200, 30), "Strawberry");
                buttonSuski = GUI.Button(new Rect(610, 585, 200, 30), "Suski");
                buttonTeimoHouse = GUI.Button(new Rect(610, 625, 200, 30), "Teimo House");
                buttonFarm = GUI.Button(new Rect(610, 665, 200, 30), "Farm");
                buttonVentti = GUI.Button(new Rect(610, 705, 200, 30), "Ventti");

                GUI.Label(new Rect(670, 795, 200, 30), "Lemoncho57");
                GUI.Label(new Rect(770, 795, 100, 30), "V1.0");
            }   
        }

        private void Mod_Update()
        {
            player = GameObject.Find("PLAYER");
            if (showGUIKey.GetKeybindDown())
            {
                if (!showGUI)
                {
                    showGUI = true;
                }
                else
                {
                    showGUI = false;
                }
            }
            TeleportPlayer();
        }

        public void TeleportPlayer()
        {
            if (buttonHome)
            {
                player.transform.position = new Vector3(-15.177f, 1.407f, 17.145f);
            }
            else if (buttonStore)
            {
                player.transform.position = new Vector3(-1548.244f, 3.864f, 1176.167f);
            }
            else if (buttonAppartments)
            {
                player.transform.position = new Vector3(-1285.978f, 1.279f, 1092.510f);
            }
            else if (buttonCottage)
            {
                player.transform.position = new Vector3(-851.547f, -2.931f, 513.823f);
            }
            else if (buttonDance)
            {
                player.transform.position = new Vector3(467.019f, 9.663f, 1334.027f);
            }
            else if (buttonDrag)
            {
                player.transform.position = new Vector3(-1294.274f, 2.500f, -940.268f);
            }
            else if (buttonInspection)
            {
                player.transform.position = new Vector3(-1533.191f, 3.910f, 1251.382f);
            }
            else if (buttonJouko)
            {
                player.transform.position = new Vector3(1940.294f, 10.460f, -219.438f);
            }
            else if (buttonLandfill)
            {
                player.transform.position = new Vector3(-786.673f, 12.324f, -644.478f);
            }
            else if (buttonRepairShop)
            {
                player.transform.position = new Vector3(1552.294f, 7.393f, 724.000f);
            }
            else if (buttonSewage)
            {
                player.transform.position = new Vector3(-1509.531f, 6.706f, 1339.559f);
            }
            else if (buttonGrandma)
            {
                player.transform.position = new Vector3(450.711f, 3.746f, -1331.618f);
            }
            else if (buttonSkiHill)
            {
                player.transform.position = new Vector3(-2026.158f, 70.244f, -115.863f);
            }
            else if (buttonStrawberry)
            {
                player.transform.position = new Vector3(-1204.493f, 1.000f, -615.625f);
            }
            else if (buttonSuski)
            {
                player.transform.position = new Vector3(-1508.801f, 5.144f, 1146.399f);
            }
            else if (buttonTeimoHouse)
            {
                player.transform.position = new Vector3(-876.792f, 8.358f, 1240.242f);
            }
            else if (buttonFarm)
            {
                player.transform.position = new Vector3(-839.139f, 2.480f, 1333.911f);
            }
            else if (buttonVentti)
            {
                player.transform.position = new Vector3(-173.285f, -4.108f, 1022.027f);
            }
        }
    }
}
