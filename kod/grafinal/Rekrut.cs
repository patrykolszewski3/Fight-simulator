using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafinal
{
    public class Rekrut : Character
    {
        
        /// <summary>
        /// Konstruktor parametryczny klasy Rekrut.
        /// Przy dodawaniu obiektu Rekrut do characterList 
        /// należy podać jego imię (name), punkty życia (hp) oraz obrażenia (damage)
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="name"></param>
        public Rekrut(string name, int hp, int damage)
        {
            // nie trzeba podawać definicji pola hp w klasie rekrut, ponieważ jest ona
            // zdefiniowana w abstrakcyjnej klasie Charakter, po której klasa Rekrut dziedzicy
            this.hp = hp; 
            this.name = name;
            this.damage = damage;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
