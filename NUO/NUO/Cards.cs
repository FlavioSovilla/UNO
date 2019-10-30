﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUO
{
    /// <summary>
    /// It's the card that contains the element from the database
    /// </summary>
    class Cards
    {
        /// <summary>
        /// Create a card
        /// </summary>
        public Cards()
        {

        }
        /// <summary>
        /// Create a card
        /// </summary>
        /// <param name="idCard">id of the card in int</param>
        /// <param name="colorCard">color from Colors</param>
        /// <param name="valueCard">value from Values</param>
        public Cards(int idCard, int colorCard, int valueCard)
        {
            Id = idCard;
            Color = colorCard;
            Value = valueCard;
        }
        //Get set to manage the cards informations
        public int Id { get; set; }
        public int Color { get; set; }
        public int Value { get; set; }

    }
}
