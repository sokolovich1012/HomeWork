// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
anyNumberText = Convert.ToString(anyNumber);
(любойNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
еще {
  Console.WriteLine("-> первых цифр нет");
}
