using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArvore_Atividade_2
{
    class Arvore
    {
        private RootNode _rootNode = new RootNode();

        public Arvore(int[] array, bool exe)
        {
            if (exe)
            {
                _rootNode = BuildArvore(array);
            }
        }

        public void PrintResultToConsole()
        {
            var left = string.Join(",", _rootNode.Left.Select(x => x.ToString()).ToArray());
            var right = string.Join(",", _rootNode.Right.Select(x => x.ToString()).ToArray());
            var text = $"Raiz: {_rootNode.BaseValue}\nGalhos da esquerda: {left}\nGalhos da direita: {right} \n";
            Console.WriteLine(text);
        }

        private RootNode BuildArvore(int[] array)
        { 
            var baseValue = HighestValue(array);
            var rootNode = new RootNode { BaseValue = baseValue, Left = new List<int>(), Right = new List<int>() };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < baseValue)
                {
                    rootNode.Left.Add(array[i]);
                }

                if (array[i] == baseValue)
                {
                    for (int b = i + 1; b < array.Length; b++)
                    {
                        rootNode.Right.Add(array[b]);
                    }
                    break;
                }
            }

            rootNode.Left.Sort();
            rootNode.Left.Reverse();

            rootNode.Right.Sort();
            rootNode.Right.Reverse();

            return rootNode;
        }


        private int HighestValue(int[] array)
        {
            int highestValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > highestValue)
                {
                    highestValue = array[i];
                }
            }

            return highestValue;
        }

        public string ReadArray(int[] array)
        {
            string result = string.Join(",", array);
            return result;
        }
    }
}

