using System.Reflection.PortableExecutable;
using IteratorAndCompositePatterns.Contracts;

namespace IteratorAndCompositePatterns.Models
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        private string _name;
        private string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i){
            return menuComponents[i];
        }

        public override string GetName(){
            return _name;
        }

        public override string GetDescription(){
            return _description;
        }

        public override void Print() {
            Console.WriteLine("\n" + GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("---------------------");

            foreach(MenuComponent menuComponent in menuComponents){
                menuComponent.Print();
            }
        }
    }
}