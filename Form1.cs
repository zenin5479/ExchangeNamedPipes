using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExchangeNamedPipes
{
   public partial class Form1 : Form
   {
      [DllImport("kernel32.dll")]
      private static extern bool AllocConsole();

      [DllImport("kernel32.dll")]
      private static extern bool FreeConsole();

      private TextBox txtNumber;
      private Button btnCalc;
      private Label lblResult;


      public Form1()
      {
         InitializeComponent();



         // Подключаем консоль к процессу
         AllocConsole();
         Console.WriteLine("=== Калькулятор факториала ===");
         Console.WriteLine("Введите число в форму и нажмите кнопку.");
         Console.WriteLine("Здесь будут отображаться шаги вычисления.\n");
      }

      private long FactorialWithConsoleLog(int n)
      {
         if (n == 0 || n == 1)
         {
            Console.WriteLine($"Факториал {n}! = 1");
            return 1;
         }

         long fact = 1;
         Console.WriteLine($"Вычисляем {n}! :");

         for (int i = 2; i <= n; i++)
         {
            fact *= i;
            Console.WriteLine($"  Шаг {i - 1}: умножаем на {i} -> текущий результат = {fact}");
         }

         Console.WriteLine($"\nРезультат: {n}! = {fact}\n");
         return fact;
      }
   }
}