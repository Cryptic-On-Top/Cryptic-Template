using UnityEngine;
using BepInEx;
using HarmonyLib;

namespace Eternal.Menu
{
    [BepInPlugin("your.guid.here", "your name here", "1.0.0")]
    internal class UI : BaseUnityPlugin
    {
        public Rect WindowRect = new Rect(0, 0, 400f, 600);
        public CurrentPage currentPage = CurrentPage.Main;
        public bool placeHolder;

        public enum CurrentPage
        {
            Main,
            Movement
        }

        void OnGUI()
        {
            WindowRect = GUILayout.Window(0, WindowRect, DrawWindow, "Eternal UI Template");
        }

        void DrawWindow(int i)
        {
            GUILayout.BeginVertical();

            switch (currentPage)
            {
                case CurrentPage.Main:
                    if (GUILayout.Button("Movement"))
                        currentPage = CurrentPage.Movement;
                    break;

                case CurrentPage.Movement:
                    if (GUILayout.Button("Main"))
                        currentPage = CurrentPage.Main;
                    break;
            }

            GUILayout.EndVertical();
            GUI.DragWindow();
        }

        void Update()
        {
            if (placeHolder)
                placeHolder = !placeHolder;
        }

        public static void Placeholder()
        {
            // leave this as a placeholder
        }

        void Awake()
        {
            Harmony harmony = new Harmony("your.guid.here");
            harmony.PatchAll();
        }
    }
}