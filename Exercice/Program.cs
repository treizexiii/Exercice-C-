using Exercice.Class;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> listArticle = new List<Article>();

            int choice = 0, p, numRef;

            do
            {
                Console.WriteLine("menu :");
                Console.WriteLine("Rechercher un article : ");
                Console.WriteLine("Ajouter un article : ");
                Console.WriteLine("Supprimer un article : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Indiquer la référence de l'article recherché :");
                        numRef = Convert.ToInt32(Console.ReadLine());
                        p = Rechercher(listArticle, numRef);
                        if(p == -1)
                        {
                            Console.WriteLine("L'article est introuvable.");
                        }
                        else
                        {
                            Console.WriteLine(listArticle[p].ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Saisissez la référence de l'article : ");
                        numRef = Convert.ToInt32(Console.ReadLine());
                        p = Rechercher(listArticle, numRef);
                        if (p != -1)
                        {
                            Console.WriteLine("L'article existe déjà");
                        }
                        else
                        {
                            Console.WriteLine("Saisissez le nom de l'article : ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Indiquez le prix : ");
                            double price = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Indiquer la quantité d'article en stock : ");
                            int quantity = Convert.ToInt32(Console.ReadLine());
                            listArticle.Add(new Article(numRef, name, price, quantity));
                        }
                        break;
                    case 3:
                        Console.WriteLine("Saisissez la référence de l'article à supprimer : ");
                        numRef = Convert.ToInt32(Console.ReadLine());
                        p = Rechercher(listArticle, numRef);
                        if(p == -1)
                        {
                            Console.WriteLine("L'article est introuvable.");
                        }
                        else
                        {
                            listArticle.RemoveAt(p);
                            Console.WriteLine("L'article a bien été supprimé.");
                        }
                        break;

                }
            } while (choice != 1);
        }

        static int Rechercher(List<Article>L,int r)
        {
            int p = -1;
            for(int i = 0; i<L.Count; i++)
            {
                if(L[i].NumRef == r)
                {
                    p = i;
                    break;
                }
            }
            return p;
        }
    }
}
