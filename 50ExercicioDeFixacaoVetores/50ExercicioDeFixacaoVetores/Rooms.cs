using System;
using System.Collections.Generic;
using System.Text;

namespace _50ExercicioDeFixacaoVetores
{
    internal class Inquilino
    {
        public int Room;
        public string Name { get; set; }
        public string Email { get; set; }

        public Inquilino()
        {

        }
        public Inquilino(int room, string name, string email)
        {
            Room = room;
            Name = name;
            Email = email;
        }
        public override string ToString()
        {
            return Room + ": " + Name + ", " + Email;
        }
    }
}

