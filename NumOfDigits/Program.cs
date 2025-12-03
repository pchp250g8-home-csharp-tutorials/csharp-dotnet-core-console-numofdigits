// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input an Integer Number:");
var strNum = Console.ReadLine();
Int64.TryParse(strNum, out var iNum);
var nDigits = 0;var iVal = Math.Abs(iNum);
while (iVal > 0)
{
    iVal /= 10;
    nDigits++;
}
Console.WriteLine("The number {0} has {1} digit(s)", iNum, nDigits);
Console.Read();