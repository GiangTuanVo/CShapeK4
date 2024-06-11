using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public enum Color
    {
        Red,
        Green,
        Blue
    }

    public enum Size
    {
        Small,
        Medium,
        Large,
        Yuge
    }

    class Product
    {
        public readonly string name;
        private Color color;
        private string size;

        public Color Color 
        { 
            get => color; 
            set => color = value; 
        }
        public string Size 
        { 
            get => size; 
            set => size = value; 
        }

        //public string Name { get; set; }
        //public string Color { get; set; }
        //public string Size { get; set; }
        public Product()
        {
        }
        public Product(string name, Color color, string size)
        {
            if (Check(size))
            {
                this.name = name;
                this.Color = color;
                this.Size = size;
            }
        }
        public Product(string name)
        {
            this.name = name;
        }

        private bool Check(string size)
        {
            switch (size)
            {
                case "Lớn":
                    return true;
                case "Vừa":
                    return true;
                case "Nhỏ":
                    return true;
                default:
                    return false;
            }
        }

        public Color GetColor()
        {
            return Color;
        }

        public override string ToString()
        {
            return $"{name}, {Color}, {Size}";
        }
    }

    class PhanSo
    {
        private int mauSo;
        private int tuSo;
        public PhanSo(int mauSo, int tuSo)
        {
            this.mauSo = mauSo;
            this.tuSo = tuSo;
        }
        public PhanSo()
        {

        }
        public PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.tuSo = a.mauSo * b.tuSo + a.tuSo * b.mauSo;
            c.mauSo = a.mauSo * b.mauSo;
            return c;
        }
        public override string ToString()
        {
            return $"{tuSo}/{mauSo}";
        }
    }

    class WriteFile
    {
        static public int number;
        static public void WriteText(string text)
        {
            File.WriteAllText("Text.txt", text);
        }
        static private int NhanVoi2()
        {
            return number * 2;
        }
    }
}
