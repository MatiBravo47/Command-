using System;

namespace Command
{
    public interface ICommand
    {
        void Ejecutar();
    }

    public class Televisor
    {
        public void Encender()
        {
            Console.WriteLine("Televisor encendido");
        }

        public void Apagar()
        {
            Console.WriteLine("Televisor apagado");
        }

        public void SubirVolumen()
        {
            Console.WriteLine("Volumen aumentado");
        }
    }

    public class EncenderTVCommand : ICommand
    {
        private Televisor _televisor;

        public EncenderTVCommand(Televisor televisor)
        {
            _televisor = televisor;
        }

        public void Ejecutar()
        {
            _televisor.Encender();
        }
    }

    public class ApagarTVCommand : ICommand 
    {
        private Televisor _televisor;

        public ApagarTVCommand(Televisor televisor) 
        {
            _televisor = televisor;
        }

        public void Ejecutar() 
        {
            _televisor.Apagar();
        }
    }

    public class SubirVolumenCommand : ICommand
    {
        private Televisor _televisor;
        public SubirVolumenCommand(Televisor televisor) 
        {
            _televisor = televisor;
        }

        public void Ejecutar() 
        {
            _televisor.SubirVolumen();
        }
    }

    public class ControlRemoto 
    {
        private ICommand _boton;

        public void SetCommand(ICommand command) 
        {
            _boton = command;
        }

        public void PresionarBoton() 
        {
            if (_boton == null)
            {
                Console.WriteLine("No hay comando asignado");
                return;
            }

            _boton.Ejecutar();
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            Televisor tv = new Televisor();
            ControlRemoto control = new ControlRemoto();

            Console.WriteLine("Cliente: presiona ENCENDER");
            control.SetCommand(new EncenderTVCommand(tv));
            control.PresionarBoton();

            Console.WriteLine();

            Console.WriteLine("Cliente: presiona SUBIR VOLUMEN");
            control.SetCommand(new SubirVolumenCommand(tv));
            control.PresionarBoton();

            Console.WriteLine();

            Console.WriteLine("Cliente: presiona APAGAR");
            control.SetCommand(new ApagarTVCommand(tv));
            control.PresionarBoton();

            Console.ReadKey();
        }
    }
}
