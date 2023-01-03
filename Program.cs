//  Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число больше 0");
int number = int.Parse(Console.ReadLine());
int avr = 2;
while(avr < number){
    Console.WriteLine(avr);
    avr = avr + 2;
}
