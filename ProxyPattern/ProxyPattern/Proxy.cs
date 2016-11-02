using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy : Subject
    {
        RealSubject rs = new RealSubject();

        public override void showComponent(string cell)
        {
            rs.showComponent(cell);
        }
    }
}
