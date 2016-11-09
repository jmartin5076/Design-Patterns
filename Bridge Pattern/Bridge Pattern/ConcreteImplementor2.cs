using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge_Pattern
{
    public class RegularUser : Implementor
    {
        public override void chooseUser()
        {
            MessageBox.Show("You are now a Regular user, enjoy your experience.", "User Status");
        }
    }
}
