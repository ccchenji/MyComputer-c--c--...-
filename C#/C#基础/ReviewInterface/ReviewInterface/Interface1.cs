using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReviewInterface
{
   public interface Person
    {
        void Eating();
        void Running();
        void Speaking();
    }
   public interface HappyPerson :Person
    {
        void Smiling();
    }
    public interface SadPerson :Person
    {
        void Crying();
    }
}
