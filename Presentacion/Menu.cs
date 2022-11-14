using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Menu
    {
        public void MenuPrincipal()
        {
            int op;
            do
            {
                Console.WriteLine("1. Crear contacto");
                Console.WriteLine("2. Consultar contactos");
                Console.WriteLine("3. eliminar contacto");
                Console.WriteLine("4. actualizar contacto");
                Console.WriteLine("5. consultar por numero de telefono ");
                Console.WriteLine("6 salir");
                Console.WriteLine(" escoja una opcion del menu: ");
                op=int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        MenuContacto();
                        break;
                    case 2:
                        MenuConsultar();
                        break;
                    case 3:
                        MenuEliminar();
                        break;
                    case 4:
                        MenuActualizar();
                        break;
                    case 5:
                        MenuConTel();
                        break;
                    case 6:
                        Environment.Exit(op=6);
                        break;
                        
                }

            } while (op !=6 );
            
        }
        Presentacion.VistaPersonal per = new Presentacion.VistaPersonal();
        public void MenuContacto()
        {
            int opcion;
            do
            {
                Console.WriteLine("------MENU CREAR CONTACTO---------");
                Console.WriteLine("1.Crear contacto personal");
                Console.WriteLine("2.Crear contacto comercial");
                Console.WriteLine("3.Volver");
                Console.WriteLine("escriba una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        per.LeerDatos();
                        break;
                    default:
                        break;
                }

            } while (opcion !=3);
        }
        
        public void MenuConsultar()
        {
            int op3;
            
            do
            {
                
                Console.WriteLine("------MENU CONSULTAR CONTACTO---------");
                Console.WriteLine("1.Consultar contacto personal");
                Console.WriteLine("2.Consultar contacto comercial");
                Console.WriteLine("3.Volver");
                Console.WriteLine("escriba una opcion: ");
                op3 = int.Parse(Console.ReadLine());

                switch (op3)
                {
                    case 1:
                        per.Mostrar();
                        break;
                    case 2:
                        break;
                    case 3:
                        MenuPrincipal();
                        break;
                }
            } while (op3 != 3);
        }
        public void MenuConTel()
        {
            int op3;
            do
            {
                Console.WriteLine("------MENU CONSULTAR CONTACTO POR TELEFONO---------");
                Console.WriteLine("1.Consultar contacto personal(por telefono)");
                Console.WriteLine("2.Consultar contacto comercial(por telefono)");
                Console.WriteLine("3.Volver");
                Console.WriteLine("escriba una opcion: ");
                op3 = int.Parse(Console.ReadLine());

                switch (op3)
                {
                    case 1:
                        per.MostrarTel();
                        break;
                    case 2:
                        break;
                    case 3:
                        MenuPrincipal();
                        break;
                }
            } while (op3 != 3);
        }
        
        public void MenuEliminar()
        {
            int op3;
            
            do
            {
                
                Console.WriteLine("------MENU ELIMINAR CONTACTO---------");
                Console.WriteLine("1.eliminar contacto personal");
                Console.WriteLine("2.eliminar contacto comercial");
                Console.WriteLine("3.Volver al menu principal");
                Console.WriteLine("escriba una opcion: ");
                op3 = int.Parse(Console.ReadLine());

                switch (op3)
                {
                    case 1:
                        Presentacion.VistaPersonal delete=new VistaPersonal();
                        delete.Eliminar();
                        break;
                    case 2:
                        break;
                    case 3:
                        MenuPrincipal();
                        break;
                }
            } while (op3 != 3);
            Console.ReadKey();
        }
        public void MenuActualizar()
        {
            int op3;
            
            do
            {
                
                Console.WriteLine("------MENU Actualizar CONTACTO---------");
                Console.WriteLine("1.actualizar contacto personal");
                Console.WriteLine("2.actualizar contacto comercial");
                Console.WriteLine("3.Volver");
                Console.WriteLine("escriba una opcion: ");
                op3 = int.Parse(Console.ReadLine());

                switch (op3)
                {
                    case 1:
                        per.Modificar();
                        break;
                    case 2:
                        break;
                    case 3:
                        MenuPrincipal();
                        break;
                }
            } while (op3 != 3);
            Console.ReadKey();
        }
    }
}
