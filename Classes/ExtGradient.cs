using System;
using UnityEngine;

namespace StupidTemplate.Classes
{
    public class ExtGradient
    {
        public static Color MenuColor = new Color32(62, 122, 157, 255);
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(Color.black, 0f),
            new GradientColorKey(MenuColor, 0.5f),
            new GradientColorKey(Color.black, 1f)
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
