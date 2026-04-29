using StupidTemplate.Menu;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate.Mods.Settings
{
    public class Movement
    {
        public static int flySpeedIndex = 2;
        public static float flySpeed = 15f;

        public static void ChangeFlySpeed()
        {
            string[] speedNames = new string[] { "Very Slow", "Slow", "Normal", "Fast", "Very Fast", "Extreme" };
            float[] speedValues = new float[] { 5f, 10f, 15f, 20f, 30f, 50f };

            flySpeedIndex++;
            flySpeedIndex %= speedNames.Length;

            GetIndex("Change Fly Speed").overlapText = $"Change Fly Speed [{speedNames[flySpeedIndex]}]";
        }

        private static float driveSpeed;
        public static int driveInt;
        public static void ChangeDriveSpeed(bool positive = true)
        {
            float[] speedamounts = { 10f, 30f, 50f, 100f, 3f };
            string[] speedNames = { "Normal", "Fast", "Ultra Fast", "The Flash", "Slow", };

            if (positive)
                driveInt++;
            else
                driveInt--;

            driveInt %= speedamounts.Length;
            if (driveInt < 0)
                driveInt = speedamounts.Length - 1;

            GetIndex("Change WASDFly Speed:").overlapText = "Change WASDFly Speed: Normal";
        }

        private static float armlength;
        private static int armlengthIndex;
        public static void ChangeArmLength()
        {
            if (armlengthIndex > 4)
            {
                armlengthIndex = 0;
            }
            switch (armlengthIndex)
            {
                case 0:
                    Main.GetIndex("Arm Length:").overlapText = "Arm Length: Normal";
                    armlength = 1.0f;
                    break;

                case 1:
                    Main.GetIndex("Arm Length:").overlapText = "Arm Length: Unnoticable";
                    armlength = 1.1f;
                    break;

                case 2:
                    Main.GetIndex("Arm Length:").overlapText = "Arm Length: Normal";
                    armlength = 1.25f;
                    break;

                case 3:
                    Main.GetIndex("Arm Length:").overlapText = "Arm Length: Noticable";
                    armlength = 1.3f;
                    break;

                case 4:
                    Main.GetIndex("Arm Length:").overlapText = "Arm Length: Long";
                    armlength = 1.4f;
                    break;

                case 5:
                    goto case 0;
            }
        }
    }
}
