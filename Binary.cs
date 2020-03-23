using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Binary
    {
        public string Bin { get; set; }
        public Binary()
        {

        }
        public Binary(string bin)
        {
            bool p = true;
            for (int i = 0; i < bin.Length; i++)
            {
                if (char.GetNumericValue(bin[i]) != 1 && char.GetNumericValue(bin[i]) != 0)
                {
                    p = false;
                    break;
                }
            }
            if (p == true)
            {
                Bin = bin;
            }
        }
        public static Binary operator +(Binary x, Binary y)
        {
            Binary Sum = new Binary();
            try
            {

                Sum.Bin = Convert.ToString(Convert.ToInt64(x.Bin, 2) + Convert.ToInt64(y.Bin, 2), 2);
                return Sum;
            }
            catch (NullReferenceException)
            {
                Sum.Bin = "Неверный ввод";
                return Sum;
            }
            catch (OverflowException)
            {
                Sum.Bin = "Слишком большое значение";
                return Sum;
            }
        } 
        public static Binary operator -(Binary x, Binary y)
        {
            Binary Sum = new Binary();
            try
            {

                Sum.Bin = Convert.ToString(Convert.ToInt64(x.Bin, 2) - Convert.ToInt64(y.Bin, 2), 2);
                return Sum;
            }
            catch (NullReferenceException)
            {
                Sum.Bin = "Неверный ввод";
                return Sum;
            }
            catch (OverflowException)
            {
                Sum.Bin = "Слишком большое значение";
                return Sum;
            }
        }
        public static Binary operator *(Binary x, Binary y)
        {
            Binary Sum = new Binary();
            try
            {

                Sum.Bin = Convert.ToString(Convert.ToInt64(x.Bin, 2) * Convert.ToInt64(y.Bin, 2), 2);
                return Sum;
            }
            catch (NullReferenceException)
            {
                Sum.Bin = "Неверный ввод";
                return Sum;
            }
            catch (OverflowException)
            {
                Sum.Bin = "Слишком большое значение";
                return Sum;
            }
        }
        public static Binary operator /(Binary x, Binary y)
        {
            Binary Sum = new Binary();
            try
            {

                Sum.Bin = Convert.ToString(Convert.ToInt64(x.Bin, 2) / Convert.ToInt64(y.Bin, 2), 2);
                return Sum;
            }
            catch (NullReferenceException)
            {
                Sum.Bin = "Неверный ввод";
                return Sum;
            }
            catch (OverflowException)
            {
                Sum.Bin = "Слишком большое значение";
                return Sum;
            }
        }
    }
}
