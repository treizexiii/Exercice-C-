using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice.Class
{
    public class Article
    {
        private int _numRef { get; set; }
        private int _quantity { get; set; }
        private string _name { get; set; }
        private double _price { get; set; }

        public int NumRef
        {
            get { return _numRef; }
            set { _numRef = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Prix
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Quantite
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public Article (int n, string na, double p, int q)
        {
            _numRef = n;
            _name = na;
            _price = p;
            _quantity = q;
        }

        public override string ToString()
        {
            return $"référence : {_numRef}, nom : {_name}, prix : {_price}, quantité : {_quantity}";
        }

    }
}
