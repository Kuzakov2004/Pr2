using System;
class Program
{
    static void Main()    
    {
        Calculation test = new Calculation();        
        test.SetCalculationLine("qwertyuiopl");
        test.SetLastSymbolCalculationLine('R');        
        test.GetCalculationLine();
        test.theLastCharacterOfTest();        
        test.DeleteLastSymbol();
        test.GetCalculationLine();    
    }
}
class Calculation
{    
    private string calculationLine;
    public void SetCalculationLine(string str)
    {        
        calculationLine = str;
    }    
    public void SetLastSymbolCalculationLine(char symbol)   
    {
        calculationLine += symbol;
    }    
    public void GetCalculationLine()    
    {
        Console.WriteLine(calculationLine);    
    }
    public void theLastCharacterOfTest()
    {        
        Console.WriteLine(calculationLine[calculationLine.Length - 1]);
    }    
    public void DeleteLastSymbol()    
    {
        calculationLine = calculationLine.Remove(calculationLine.Length - 1);    
    }
}