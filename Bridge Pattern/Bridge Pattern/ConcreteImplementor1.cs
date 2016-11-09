using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge_Pattern
{
    public class AdminUser : Implementor
    {
        public override void chooseUser()
        {
            MessageBox.Show("You are now an Admin user, enjoy changing the computer as you see fit.", "User Status");
        }
    }
}
