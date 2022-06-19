using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite abaixo 10 números");

            int[] nums1 = new int[10];
            int[] nums2 = new int[10];

            for (int i = 0; i < nums1.Length; i++)
            {
                Console.WriteLine("Digite um número: ");
                nums1[i] = Convert.ToInt32(Console.ReadLine());
                if (nums1[i] > 0)
                {
                    nums2[i] = nums1[i] * 5;
                }
                else
                {
                    Console.WriteLine("Digite um número acima de 0");
                }

            }

            Console.WriteLine("\nVocê digitou esses números");

            foreach (int num in nums1)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nPegamos os seus números digitados e multiplicamos por 5");

            foreach (int num in nums2)
            {
                if (num > 0) Console.WriteLine(num);
            }
        }
    }
}
