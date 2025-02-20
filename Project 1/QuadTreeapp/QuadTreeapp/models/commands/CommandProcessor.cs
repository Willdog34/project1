using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadTreeapp.models.commands
{
    internal class CommandProcessor
    {
        internal void ProcessCommand(string line)
        {
            throw new NotImplementedException();
        }
    }
}
//here is the code that should be in the CommandProcessor.cs file

namespace QuadTreeApp.Commands
{
    public class CommandProcessor
    {
        private QuadtreeApp quadtree;

        public CommandProcessor()
        {
            quadtree = new Quadtreeapp();
        }

        public void ProcessCommand(string command)
        {
            var parts = command.Split(' ');
            if (parts.Length == 0) return;

            switch (parts[0].ToLower())
            {
                case "insert":
                    ExecuteInsert(parts);
                    break;
                case "find":
                    ExecuteFind(parts);
                    break;
                case "delete":
                    ExecuteDelete(parts);
                    break;
                case "update":
                    ExecuteUpdate(parts);
                    break;
                case "dump":
                    quadtree.Dump();
                    break;
                default:
                    Console.WriteLine($"Invalid command: {command}");
                    break;
            }
        }

        private void ExecuteInsert(string[] parts)
        {
            if (parts.Length != 5)
            {
                Console.WriteLine("Invalid Insert command. Usage: Insert X Y L W");
                return;
            }

            int x = int.Parse(parts[1]);
            int y = int.Parse(parts[2]);
            int width = int.Parse(parts[3]);
            int height = int.Parse(parts[4]);

            if (quadtree.Find(x, y) != null)
            {
                Console.WriteLine("You cannot double insert at a position.");
                return;
            }

            quadtree.Insert(x, y, width, height);
            Console.WriteLine($"Inserted rectangle at ({x}, {y}) with size {width}x{height}.");
        }

        private void ExecuteFind(string[] parts)
        {
            if (parts.Length != 3)
            {
                Console.WriteLine("Invalid Find command. Usage: Find X Y");
                return;
            }

            int x = int.Parse(parts[1]);
            int y = int.Parse(parts[2]);
            var rect = quadtree.Find(x, y);

            if (rect != null)
            {

                Console.WriteLine(value: $"Rectangle at {x}, {y}: {rect.Width}x{rect.Height}");//give me Errors
            }
            else
            {
                Console.WriteLine($"Nothing is at {x}, {y}.");
            }
        }

        private void ExecuteDelete(string[] parts)
        {
            if (parts.Length != 3)
            {
                Console.WriteLine("Invalid Delete command. Usage: Delete X Y");
                return;
            }

            int x = int.Parse(parts[1]);
            int y = int.Parse(parts[2]);

            if (quadtree.Find(x, y) == null)
            {
                Console.WriteLine($"Nothing to delete at {x}, {y}.");
                return;
            }

            quadtree.Delete(x, y);
            Console.WriteLine($"Deleted rectangle at {x}, {y}.");
        }

        private void ExecuteUpdate(string[] parts)
        {
            if (parts.Length != 5)
            {
                Console.WriteLine("Invalid Update command. Usage: Update X Y L W");
                return;
            }

            int x = int.Parse(parts[1]);
            int y = int.Parse(parts[2]);
            int newWidth = int.Parse(parts[3]);
            int newHeight = int.Parse(parts[4]);

            var rect = quadtree.Find(x, y);
            if (rect == null)
            {
                Console.WriteLine($"Nothing to update at {x}, {y}.");
                return;
            }

            rect.Width = newWidth;//give error
            rect.Height = newHeight;//give error
            Console.WriteLine($"Updated rectangle at {x}, {y} to size {newWidth}x{newHeight}.");
        }
    }

    internal class QuadtreeApp
    {
        internal void Delete(int x, int y)
        {
            throw new NotImplementedException();
        }

        internal void Dump()
        {
            throw new NotImplementedException();
        }

        internal object Find(int x, int y)
        {
            throw new NotImplementedException();
        }

        internal void Insert(int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public static implicit operator QuadtreeApp(Quadtreeapp v)
        {
            throw new NotImplementedException();
        }
    }

    internal class Quadtreeapp
    {
        public Quadtreeapp()
        {
        }
    }
}
