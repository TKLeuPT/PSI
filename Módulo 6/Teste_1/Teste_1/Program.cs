using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Queue<string> draCarla = new Queue<string>();
            Queue<string> draRita = new Queue<string>();
            Queue<string> drJoao = new Queue<string>();
            Queue<string> drPedro = new Queue<string>();

            Menu:
            Console.WriteLine("1.Inserir um Paciente");
            Console.WriteLine("2.Procurar um Paciente");
            

            int switch_on = int.Parse(Console.ReadLine());
            switch (switch_on)
            {
                case 1:
                    Console.WriteLine("Insira o nome do Paciente: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Insira o nome do Médico");
                    Console.WriteLine("Médicos Disponivies: Drª Carla, Drª Rita, Dr João, Dr Pedro ");
                    string medico = Console.ReadLine();
                    while (medico != "Drª Carla" || medico != "Drª Rita" || medico != "Dr João" || medico != "Dr Pedro")
                    {
                        Console.WriteLine("Médico inserido não existente!");
                        Console.WriteLine("Insira o nome do Médico");
                        medico = Console.ReadLine();
                        if ((medico == "Drª Carla" || medico == "Drª Rita" || medico == "Dr João" || medico == "Dr Pedro"))
                        {
                            break;  
                        }
                    }

                    if (medico == "Drª Carla")
                    {
                        draCarla.Enqueue(nome);
                        Console.WriteLine("Estão neste momento {0} pessoas nesta fila.",draCarla.Count);
                        if (draCarla.Count > draRita.Count)
                        {
                            Console.WriteLine("A fila da Drª Rita tem menos pacientes, deseja trocar de médico?");
                            Console.WriteLine("1.Sim");
                            Console.WriteLine("2.Não");
                            int mudar = int.Parse(Console.ReadLine());
                            switch (mudar)
                            {
                                case 1:
                                    if (draCarla.Contains(nome))
                                    {
                                        draCarla.Dequeue();
                                        draRita.Enqueue(nome);
                                        Console.WriteLine("Troca efectuada com sucesso!");
                                    }
                                    break;
                                case 2:
                                    break;
                            }
                        }

                        if (draCarla.Count > drJoao.Count)
                        {
                            Console.WriteLine("A fila do Dr João tem menos pacientes, deseja trocar de médico?");
                            Console.WriteLine("1.Sim");
                            Console.WriteLine("2.Não");
                            int mudar = int.Parse(Console.ReadLine());
                            switch (mudar)
                            {
                                case 1:
                                    if (draCarla.Contains(nome))
                                    {
                                        draCarla.Dequeue();
                                        drJoao.Enqueue(nome);
                                        Console.WriteLine("Troca efectuada com sucesso!");
                                    }
                                    break;
                                case 2:
                                    break;
                            }
                        }

                        if (draCarla.Count > drPedro.Count)
                        {
                            Console.WriteLine("A fila do Dr Pedro tem menos pacientes, deseja trocar de médico?");
                            Console.WriteLine("1.Sim");
                            Console.WriteLine("2.Não");
                            int mudar = int.Parse(Console.ReadLine());
                            switch (mudar)
                            {
                                case 1:
                                    if (draCarla.Contains(nome))
                                    {
                                        draCarla.Dequeue();
                                        drPedro.Enqueue(nome);
                                        Console.WriteLine("Troca efectuada com sucesso!");
                                    }
                                    break;
                                case 2:
                                    break;
                            }
                        }
                    }

                    if (medico == "Drª Rita")
                    {
                        draRita.Enqueue(nome);
                        Console.WriteLine("Estão neste momento {0} pessoas nesta fila.", draRita.Count);

                        if (draRita.Count > draCarla.Count)
                        {
                            Console.WriteLine("A fila da Drª Carla tem menos pacientes, deseja trocar de médico?");
                            Console.WriteLine("1.Sim");
                            Console.WriteLine("2.Não");
                            int mudar = int.Parse(Console.ReadLine());
                            switch (mudar)
                            {
                                case 1:
                                    if (draRita.Contains(nome))
                                    {
                                        draRita.Dequeue();
                                        draCarla.Enqueue(nome);
                                        Console.WriteLine("Troca efectuada com sucesso!");
                                    }
                                    break;
                                case 2:
                                    break;
                            }
                        }

                        if (draRita.Count > drJoao.Count)
                        {
                            Console.WriteLine("A fila do Dr João tem menos pacientes, deseja trocar de médico?");
                            Console.WriteLine("1.Sim");
                            Console.WriteLine("2.Não");
                            int mudar = int.Parse(Console.ReadLine());
                            switch (mudar)
                            {
                                case 1:
                                    if (draRita.Contains(nome))
                                    {
                                        draRita.Dequeue();
                                        drJoao.Enqueue(nome);
                                        Console.WriteLine("Troca efectuada com sucesso!");
                                    }
                                    break;
                                case 2:
                                    break;
                            }
                        }

                        if (draRita.Count > drPedro.Count)
                        {
                            Console.WriteLine("A fila do Dr Pedro tem menos pacientes, deseja trocar de médico?");
                            Console.WriteLine("1.Sim");
                            Console.WriteLine("2.Não");
                            int mudar = int.Parse(Console.ReadLine());
                            switch (mudar)
                            {
                                case 1:
                                    if (draRita.Contains(nome))
                                    {
                                        draRita.Dequeue();
                                        drPedro.Enqueue(nome);
                                        Console.WriteLine("Troca efectuada com sucesso!");
                                    }
                                    break;
                                case 2:
                                    break;
                            }
                        }

                    }

                    if (medico == "Dr João")
                    {
                        drJoao.Enqueue(nome);
                        Console.WriteLine("Estão neste momento {0} pessoas nesta fila.", drJoao.Count);

                        if (drJoao.Count > draCarla.Count)
                        {
                            Console.WriteLine("A fila da Drª Rita tem menos pacientes, deseja trocar de médico?");
                            Console.WriteLine("1.Sim");
                            Console.WriteLine("2.Não");
                            int mudar = int.Parse(Console.ReadLine());
                            switch (mudar)
                            {
                                case 1:
                                    if (drJoao.Contains(nome))
                                    {
                                        drJoao.Dequeue();
                                        draCarla.Enqueue(nome);
                                        Console.WriteLine("Troca efectuada com sucesso!");
                                    }
                                    break;
                                case 2:
                                    break;
                            }
                        }

                        if (drJoao.Count > draRita.Count)
                        {
                            Console.WriteLine("A fila da Dr Rita tem menos pacientes, deseja trocar de médico?");
                            Console.WriteLine("1.Sim");
                            Console.WriteLine("2.Não");
                            int mudar = int.Parse(Console.ReadLine());
                            switch (mudar)
                            {
                                case 1:
                                    if (drJoao.Contains(nome))
                                    {
                                        drJoao.Dequeue();
                                        draRita.Enqueue(nome);
                                        Console.WriteLine("Troca efectuada com sucesso!");
                                    }
                                    break;
                                case 2:
                                    break;
                            }
                        }

                        if (drJoao.Count > drPedro.Count)
                        {
                            Console.WriteLine("A fila do Dr Pedro tem menos pacientes, deseja trocar de médico?");
                            Console.WriteLine("1.Sim");
                            Console.WriteLine("2.Não");
                            int mudar = int.Parse(Console.ReadLine());
                            switch (mudar)
                            {
                                case 1:
                                    if (drJoao.Contains(nome))
                                    {
                                        drJoao.Dequeue();
                                        drPedro.Enqueue(nome);
                                        Console.WriteLine("Troca efectuada com sucesso!");
                                    }
                                    break;
                                case 2:
                                    break;
                            }
                        }

                    }
            
                    if (medico == "Dr Pedro")
                    {
                        drPedro.Enqueue(nome);
                        Console.WriteLine("Estão neste momento {0} pessoas nesta fila.", drPedro.Count);

                        if (drPedro.Count > draCarla.Count)
                        {
                            Console.WriteLine("A fila da Drª Carla tem menos pacientes, deseja trocar de médico?");
                            Console.WriteLine("1.Sim");
                            Console.WriteLine("2.Não");
                            int mudar = int.Parse(Console.ReadLine());
                            switch (mudar)
                            {
                                case 1:
                                    if (drPedro.Contains(nome))
                                    {
                                        drPedro.Dequeue();
                                        draCarla.Enqueue(nome);
                                        Console.WriteLine("Troca efectuada com sucesso!");
                                    }
                                    break;
                                case 2:
                                    break;
                            }
                        }

                        if (drPedro.Count > draRita.Count)
                        {
                            Console.WriteLine("A fila da Dr Rita tem menos pacientes, deseja trocar de médico?");
                            Console.WriteLine("1.Sim");
                            Console.WriteLine("2.Não");
                            int mudar = int.Parse(Console.ReadLine());
                            switch (mudar)
                            {
                                case 1:
                                    if (drPedro.Contains(nome))
                                    {
                                        drPedro.Dequeue();
                                        draRita.Enqueue(nome);
                                        Console.WriteLine("Troca efectuada com sucesso!");
                                    }
                                    break;
                                case 2:
                                    break;
                            }
                        }

                        if (drPedro.Count > drJoao.Count)
                        {
                            Console.WriteLine("A fila do Dr João tem menos pacientes, deseja trocar de médico?");
                            Console.WriteLine("1.Sim");
                            Console.WriteLine("2.Não");
                            int mudar = int.Parse(Console.ReadLine());
                            switch (mudar)
                            {
                                case 1:
                                    if (drPedro.Contains(nome))
                                    {
                                        drPedro.Dequeue();
                                        drJoao.Enqueue(nome);
                                        Console.WriteLine("Troca efectuada com sucesso!");
                                    }
                                    break;
                                case 2:
                                    break;
                            }
                        }
                    }
                    
                    break;
                case 2:
                    Console.WriteLine("Insira o nome a procurar: ");
                    string nomep = Console.ReadLine();
                    if (draCarla.Contains(nomep))
                    {
                        for (int i = 0; i < draCarla.Count; i++)
                        {
                            if (draCarla.ElementAt(i) == nomep)
                            {
                                Console.WriteLine("Estão {0} pessoas à sua frente", i);


                            }
                        }
                        Console.WriteLine("1.Remover um Paciente");
                        Console.WriteLine("2.Mostrar Pacientes");
                        int switch1 = int.Parse(Console.ReadLine());
                        switch (switch1)
                        {
                            case 1:
                                draCarla.Dequeue();
                                break;
                            case 2:
                                foreach (var item in draCarla)
                                {
                                    Console.WriteLine("Dr Carla Nº de Pessoas: {0} Nome: {1} ", drPedro.Count);
                                }
                                break;
                        }
                    }
                    else Console.WriteLine("Não está ninguem à sua frente.");
                    if (draRita.Contains(nomep))
                    {
                        for (int i = 0; i < draRita.Count; i++)
                        {
                            if (draRita.ElementAt(i)==nomep)
                            {
                                Console.WriteLine("Estão {0} pessoas à sua frente",i);
                            }
                        }
                        Console.WriteLine("1.Remover um Paciente");
                        Console.WriteLine("2.Mostrar Pacientes");
                        int switch1 = int.Parse(Console.ReadLine());
                        switch (switch1)
                        {
                            case 1:
                                draRita.Dequeue();
                                break;
                            case 2:
                                foreach (var item in draRita)
                                {
                                    Console.WriteLine("Dr Rita Nº de Pessoas: {0} Nome: ", drPedro.Count);
                                }
                                break;
                        }
                    }
                    else Console.WriteLine("Não está ninguem à sua frente.");
                    if (drJoao.Contains(nomep))
                    {
                        for (int i = 0; i < drJoao.Count; i++)
                        {
                            if (drJoao.ElementAt(i) == nomep)
                            {
                                Console.WriteLine("Estão {0} pessoas à sua frente", i);
                               
                            }
                        }
                        Console.WriteLine("1.Remover um Paciente");
                        Console.WriteLine("2.Mostrar Pacientes");
                        int switch1 = int.Parse(Console.ReadLine());
                        switch (switch1)
                        {
                            case 1:
                                drJoao.Dequeue();
                                break;
                            case 2:
                                foreach (var item in drJoao)
                                {
                                    Console.WriteLine("Dr João Nº de Pessoas: {0} Nome: {1} ", drPedro.Count);
                                }
                                break;
                        }
                    }
                    else Console.WriteLine("Não está ninguem à sua frente.");
                    if (drPedro.Contains(nomep))
                    {
                        for (int i = 0; i < drPedro.Count; i++)
                        {
                            if (drPedro.ElementAt(i) == nomep)
                            {
                                Console.WriteLine("Estão {0} pessoas à sua frente", i);
                            }
                        }
                        Console.WriteLine("1.Remover um Paciente");
                        Console.WriteLine("2.Mostrar Pacientes");
                        int switch1 = int.Parse(Console.ReadLine());
                        switch (switch1)
                        {
                            case 1:
                                drPedro.Dequeue();
                                break;
                            case 2:
                                foreach (var item in drPedro)
                                {
                                    Console.WriteLine("Dr Pedro Nº de Pessoas: {0} Nome: {1} ",drPedro.Count);
                                }
                                break;
                        }
                    }
                    else Console.WriteLine("Não está ninguem à sua frente.");
                    break;
               
            }
            goto Menu;
        }
    }
}
