// Console.ReadLine: lê uma linha com dados de Entrada (Input) do usuario;
// Console.WriteLine: imprime um texto de saída (Output) e pulando uma linha;

using System;

public class index{
        public static void Main()
  {
     // Lê os valores de Entrada:
     float valorSalario = float.Parse(Console.ReadLine());
     float valorBeneficio = float.Parse(Console.ReadLine());

      float valorImposto = 0;
      if(valorSalario >= 0 && valorSalario <= 1100)
      {
        //Atribui a aliquota de 5% mediante o salário:
        valorImposto = 0.05F * valorSalario;
      } 
      else if(valorSalario >= 1100.01 && valorSalario <= 2500.00)
      {
        valorImposto = 0.10F * valorSalario;
      } 
      else 
      {
        valorImposto = 0.15F * valorSalario;
      }

      //Calcula e imprime a saída (com 2 casas decimais):
      float saida = valorSalario - valorImposto + valorBeneficio;
      Console.WriteLine(saida.ToString("0.00"));
    } 
}