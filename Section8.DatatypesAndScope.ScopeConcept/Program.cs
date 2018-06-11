using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8.DatatypesAndScope.ScopeConcept
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
        public void Test()
        {
            
            //x = 7;//error
            {
                
                //x = 8; //error
                {
                    int x = 0;

                }
                
            }
        }
    }
}
