using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca contaDeBernardo = new ContaPoupanca();
            contaDeBernardo.titular = "Bernardo";
            contaDeBernardo.agencia = 0001;
            contaDeBernardo.saldo = 1000;

            Console.WriteLine("Titular: " + contaDeBernardo.titular);
            Console.WriteLine("Agencia: " + contaDeBernardo.agencia);
            Console.WriteLine("Saldo: " + contaDeBernardo.saldo);

            contaDeBernardo.Sacar(500);

            Console.WriteLine("Novo saldo: " + contaDeBernardo.saldo);

            contaDeBernardo.Depositar(200);

            Console.WriteLine("Novo saldo: " + contaDeBernardo.saldo);

            ContaPoupanca contaDeRafaela = new ContaPoupanca();

            contaDeRafaela.titular = "Rafaela";
            contaDeRafaela.agencia = 0002;
            contaDeRafaela.saldo = 1000;

            Console.WriteLine("Titular: " + contaDeRafaela.titular);
            Console.WriteLine("Agencia: " + contaDeRafaela.agencia);
            Console.WriteLine("Saldo: " + contaDeRafaela.saldo);

            contaDeRafaela.Transferir(200, contaDeBernardo);

            Console.WriteLine("Saldo: " + contaDeRafaela.saldo);
            Console.WriteLine("Saldo: " + contaDeBernardo.saldo);

            Console.ReadLine();
        }
    }
}
