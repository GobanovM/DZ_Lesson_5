using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson_5
{
    internal class Level
    {
        public Level(decimal Price) 
        {
            PriceLevel = Price;
        }
        
        
        //================================== Fields =================================
        #region Fields
        
        /// <summary>
        /// Цена уровня
        /// </summary>
        public decimal PriceLevel = 0;

        /// <summary>
        /// Лот на уровень
        /// </summary>
        public decimal LotLevel = 0;

        /// <summary>
        /// Открытый объем на уровне
        /// </summary>
        public decimal Volume = 0;

        #endregion
    }
}
