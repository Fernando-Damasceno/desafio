using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace projeto_athletic_gear
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] senha = new string[4] { "#forTe1", "senhafraca", "Qu@s1", "Voce@Consegue!2023" };
      string resposta = "";

      for (int i = 0; i < senha.Length; i++)
      {
        string validasenha = senha[i];

        bool validamaiuscula = LetraMaiuscula(validasenha);

        bool validaminuscula = LetraMinuscula(validasenha);

        bool validaCaractereEspecial = CaracterEspecial(validasenha);

        if (validasenha.Length <= 6)
        {
          Console.WriteLine("A senha é inferior a 7 caracteres\n");
        }
        else if (!validamaiuscula)
        {
          Console.WriteLine("A senha não possui uma letra maiuscula\n");
        }
        else if (!validaminuscula)
        {
          Console.WriteLine("A senha não possui uma letra minuscula\n");
        }
        else if(!validaCaractereEspecial)
        {
          Console.WriteLine("A senha não possui um caracter especial\n");
        }
        else
        {
          resposta += $"{validasenha} \n";
        }

      }
      Console.WriteLine(resposta);
      Console.ReadKey();
    }

    public static bool LetraMaiuscula(string texto)
    {
      char[] letra = texto.ToCharArray();
      bool validacao = false;

      for(int i = 0; i < letra.Length; i++)
      {
        string maiuscula = letra[i].ToString();
        string testemaiuscula = maiuscula.ToUpper();
        
        if(maiuscula == testemaiuscula) 
        {
          validacao = true;
          break;
        }
      }

      return validacao;
    }

    public static bool LetraMinuscula(string texto)
    {
      char[] letra = texto.ToCharArray();
      bool validacao = false;

      for (int i = 0; i < letra.Length; i++)
      {
        string minuscula = letra[i].ToString();
        string testeminuscula = minuscula.ToLower();

        if (minuscula == testeminuscula)
        {
          validacao = true;
          break;
        }
      }

      return validacao;
    }

    public static bool CaracterEspecial(string texto)
    {
      char[] letra = texto.ToCharArray();
      bool validacao = false;

      for (int i = 0; i < letra.Length; i++)
      {
        string maiuscula = letra[i].ToString();
        bool existeCaracterEspecial = Regex.IsMatch(maiuscula, (@"[^a-zA-Z0-9]"));


        if (existeCaracterEspecial)
        {
          validacao = true;
          break;
        }
      }

      return validacao;
    }

  }
}
