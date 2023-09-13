using System;

public delegate int Operacao(int x, int y);
class Program {
    public class Calculadora {
        public int ExecutarOperacao(int a, int b, Operacao op) {
            return op(a, b);
        }

    }
    public static int Soma(int a, int b) {
        return a + b;
    }

    public static int Subtracao(int a, int b) {

        return a - b;   
    }


    public static int Multiplicacao(int a, int b) {

        return a * b;
    }

    public static int Divisao(int a, int b) {

        return a / b;
    }


    public static void Main() {
        Calculadora calc = new Calculadora();

        Operacao op = Soma;

        Console.WriteLine("Executando Soma:  "+ calc.ExecutarOperacao(4, 5, op));

        op = Subtracao;

        Console.WriteLine("Executando subtracao: " + calc.ExecutarOperacao(10,5, op));

        op = Multiplicacao;

        Console.WriteLine("Executando Multiplicacao: " + calc.ExecutarOperacao(10, 5, op));


        op = Divisao;

        Console.WriteLine("Executando Divisao: " + calc.ExecutarOperacao(10, 5, op));

        Console.ReadKey();

    }
}
