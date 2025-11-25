namespace TakeAction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energia = 0;
            int motivacion = 0;
            int estres = 0;
            int enfoque = 0;
            bool run = true;



            List<string> rEjercicios = new List<string>
                {"Llovio mucho, no pudiste ir", "Conseguiste tu PR en un ejercicio"};

            List<string> rProcrastinar = new List<string>
                {"Te sentiste triste luego de hacerlo", "No pudiste entregar la tarea"};

            List<string> rEstudiar = new List<string>
                {"Duraste 2 horas sind darte cuenta", "La soltaste rapido y seguiste estudiando"};

            List<string> rMeditar = new List<string>
                {"Te sentiste en paz", "Descubriste algo nuevo en ti"};

            while (run)
            {

                Console.WriteLine("Simulador de Vida Iniciado");

                Console.WriteLine("1. Hacer ejercicio");
                Console.WriteLine("2.Procrastinar");
                Console.WriteLine("3.Estudiar");
                Console.WriteLine("4.Meditar unos minutos");
                Console.WriteLine("5.Salir del programa");
                Console.Write("Que deseas hacer en este momento? ");
                int eleccionUsuario = Convert.ToInt32(Console.ReadLine());

                if (eleccionUsuario == 1)
                {
                    Random rnd = new Random();
                    int index = rnd.Next(0, 2);
                    //Console.WriteLine(rEjercicios[index]);
                    //break;

                    if (index == 0)
                    {
                        energia -= 20;
                        motivacion -= 40;
                        estres -=  30;
                        enfoque -= 10;
                        Console.WriteLine("Mañana hará un mejor tiempo, no te desanimes!");
                    }

                    else if (index == 1)
                    {
                        energia += 50;
                        motivacion += 30;
                        enfoque += 20;
                        Console.WriteLine("Perfecto, sigue asi!");
                    }

                    energia = Math.Clamp(energia, 0, 100);
                    motivacion = Math.Clamp(motivacion, 0, 100);
                    enfoque = Math.Clamp(enfoque, 0, 100);
                    estres = Math.Clamp(estres, 0, 100);
                   


                    Console.WriteLine($"Actualmente tu energia actual es de: {energia}, tu motivacion de: {motivacion}, tu enfoque de {enfoque} mientras tu estres es de {estres}. Piensa bien en tu proxima accion. ");

                }

                else if (eleccionUsuario == 2)
                {

                    Random rnd = new Random();
                    int index = rnd.Next(0, 2);

                    if (index == 0)
                    {
                        energia -= 50;
                        motivacion -= 30;
                        estres -= 20;
                        enfoque -= 25;
                        Console.WriteLine("Deberias ponerte a hacer tus deberes");
                    }

                    else if (index == 1)
                    {
                        energia -= 20;
                        motivacion -= 40;
                        estres -= 45;
                        enfoque -= 25;
                        Console.WriteLine("Concentrate para la proxima!");


                    }
                    energia = Math.Clamp(energia, 0, 100);
                    motivacion = Math.Clamp(motivacion, 0, 100);
                    enfoque = Math.Clamp(enfoque, 0, 100);
                    estres = Math.Clamp(estres, 0, 100);



                    Console.WriteLine($"Actualmente tu energia actual es de: {energia}, tu motivacion de: {motivacion}, tu enfoque de {enfoque} mientras tu estres es de {estres}. Piensa bien en tu proxima accion. ");


                }

                else if (eleccionUsuario == 3)
                {

                    Random rnd = new Random();
                    int index = rnd.Next(0, 2);

                    if (index == 0)
                    {
                        energia -= 30;
                        estres -= 25;
                        motivacion -= 20;
                        enfoque -= 15;
                        Console.WriteLine("Aun te queda todo el dia, animo!");

                    }

                    else if (index == 1)
                    {
                        energia += 5;
                        motivacion += 40;
                        enfoque += 30;
                        Console.WriteLine("Excelenete, asi se hace!");

                    }

                    energia = Math.Clamp(energia, 0, 100);
                    motivacion = Math.Clamp(motivacion, 0, 100);
                    enfoque = Math.Clamp(enfoque, 0, 100);
                    estres = Math.Clamp(estres, 0, 100);



                    Console.WriteLine($"Actualmente tu energia actual es de: {energia}, tu motivacion de: {motivacion}, tu enfoque de {enfoque} mientras tu estres es de {estres}. Piensa bien en tu proxima accion. ");


                }

                else if (eleccionUsuario == 4)
                {

                    Random rnd = new Random();
                    int index = rnd.Next(0, 2);

                    if (index == 0)
                    {
                        energia += 10;
                        motivacion += 20;
                        enfoque += 40;
                        Console.WriteLine("Sigue asi!");
                    }

                    else if (index == 1)
                    {
                        energia += 10;
                        motivacion += 40;
                        enfoque += 20;
                        Console.WriteLine("Que importante es eso!");

                    }

                    energia = Math.Clamp(energia, 0, 100);
                    motivacion = Math.Clamp(motivacion, 0, 100);
                    enfoque = Math.Clamp(enfoque, 0, 100);
                    estres = Math.Clamp(estres, 0, 100);



                    Console.WriteLine($"Actualmente tu energia actual es de: {energia}, tu motivacion de: {motivacion}, tu enfoque de {enfoque} mientras tu estres es de {estres}. Piensa bien en tu proxima accion. ");



                }

                else if (eleccionUsuario == 5)
                {
                    run = false;
                    break;
                }

                else
                {
                    Console.WriteLine("Debes elegir una de las opciones proporcionadas.");
                }

         
            }
        }
    }
}