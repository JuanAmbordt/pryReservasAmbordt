using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryReservasAmbordt
{
    internal class clsEstadoPct
    {
       
        private static Dictionary<string, Color> pictureBoxStates = new Dictionary<string, Color>();

        public static void ActualizarPictureBox(string pictureBoxName, Color color)
        {
            if (pictureBoxStates.ContainsKey(pictureBoxName))
            {
                pictureBoxStates[pictureBoxName] = color;
            }
            else
            {
                pictureBoxStates.Add(pictureBoxName, color);
            }
        }

        public static Color ObtenerPictureBox(string pictureBoxName)
        {
            if (pictureBoxStates.ContainsKey(pictureBoxName))
            {
                return pictureBoxStates[pictureBoxName];
            }
            return Color.Transparent; 
        }
    }
}
