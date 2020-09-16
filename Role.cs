using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Role
    {
        private string _name;
        private int _health;
        private int _damage;
        public string _role;

        public Role()
        {
            _health = 100;
            _damage = 10;
        }

        public Role(string nameVal, int healthVal, int damageVal)
        {
            _name = nameVal;
            _health = healthVal;
            _damage = damageVal;
        }

        //public void ChooseRole




    }
}
