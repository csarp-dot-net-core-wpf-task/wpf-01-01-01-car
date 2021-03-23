using System;
using System.Collections.Generic;
using System.Text;

namespace wpf_01_01_01_car.model
{
    /// <summary>
    /// Autó osztály
    /// </summary>
    class Car
    {
        /// <summary>
        /// tulajdonos
        /// </summary>
        private string owner;

        /// <summary>
        /// Konstruktor (autó tulajdonos nevének megadásával jön létre)
        /// </summary>
        /// <param name="owner">autó tulajdonos</param>
        public Car(string owner)
        {
            this.owner = owner;
        }

        /// <summary>
        /// az autó elmegy a munkahelyre
        /// </summary>
        public string GoToWorkString()
        {
            return owner + " autója tulajdonosát elviszi a munkahelyre.";
        }
        /// <summary>
        /// Az autó hazajön a munkahelyről.
        /// </summary>
        public string ComingHomeString()
        {
            return owner + " autója tulajdonosát elviszi haza.";
        }
    }
}
