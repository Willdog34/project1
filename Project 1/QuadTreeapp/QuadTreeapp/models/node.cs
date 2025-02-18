using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadTreeApp.UnitTests.Models
{
    public abstract class Node
    {
        public int X { get; protected set; } // this should be fine
        public int Y { get; protected set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public abstract void Delete(int x, int y);
        public abstract Rectangle Find(int x, int y);
        public abstract void Dump(int level);

        public abstract void Insert(Rectangle x);
    }

    
    }

