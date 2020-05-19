using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200518_MVC
{
    interface IViewController
    {
        object M(object model);
    }

    interface IModelController
    {
        void V();
    }

    interface IView
    {
        void V();

        void SetAdapterIViewController(IViewController controller);
    }

    interface IModel
    {
        object M(object model);

        void SetAdapterIModelController(IModelController controller);
    }

    //Implementacija Factory desing pattern

    delegate IView ViewFacotry();
    delegate IModel ModelFactory();

    class View : IView
    {
        private IViewController _Controller;

        public void SetAdapterIViewController(IViewController controller)
        {
            _Controller = controller;
        }

        public void V()
        {
            Console.WriteLine("Iveskite duomenis");
            string data = Console.ReadLine();
            Console.WriteLine((string)_Controller.M(data));
        }
    }


    class Model : IModel
    {
        private IModelController _Controller;

        public void SetAdapterIModelController(IModelController controller)
        {
            _Controller = controller;
        }

        public object M(object model)
        {
            return "$" + (string)model + "$";
        }
    }

    class ModelisSuZvaigzde : IModel
    {
        private IModelController _Controller;

        public void SetAdapterIModelController(IModelController controller)
        {
            _Controller = controller;
        }

        public object M(object model)
        {
            return "*" + (string)model + "*";
        }
    }

    class ViewEnglish : IView
    {
        private IViewController _Controller;

        public void SetAdapterIViewController(IViewController controller)
        {
            _Controller = controller;
        }

        public void V()
        {
            Console.WriteLine("Please enter data");
            var data = Console.ReadLine();
            Console.WriteLine((string)_Controller.M(data));
        }
    }

    class Controller : IModelController, IViewController
    {
        private IModel Modelis;
        private IView View;

        public Controller(ModelFactory m, ViewFacotry v)
        {
            Modelis = m();
            View = v();

            Modelis.SetAdapterIModelController(this);
            View.SetAdapterIViewController(this);
        }

        public object M(object model)
        {
            return Modelis.M(model);
        }

        public void V()
        {
            View.V();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Controller c = new Controller(StartModelFactory, ViewEnglsihFactory);
            c.V();
        }

        private static IView ViewFactory()
        {
            return new View();
        }

        private static IModel ModelFactory()
        {
            return new Model();
        }

        private static IView ViewEnglsihFactory()
        {
            return new ViewEnglish();
        }

        private static IModel StartModelFactory()
        {
            return new ModelisSuZvaigzde();
        }
    }
}
