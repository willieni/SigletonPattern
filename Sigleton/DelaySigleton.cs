using System;
using System.Collections.Generic;
using System.Text;

namespace SigletonPattern.Sigleton
{
    public class DelaySigleton
    {
        private DelaySigleton()
        {
        }

        public static DelaySigleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            static Nested()
            {
            }

            internal static readonly DelaySigleton instance = new DelaySigleton();
        }
    }
}
