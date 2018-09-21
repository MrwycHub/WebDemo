using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Demo
{
    class ColorEnumerator:IEnumerator
    {
        string[] _colors;
        int _position=-1;
        //1、构造函数
        public ColorEnumerator(string [] theColors)
        {
            _colors = new string[theColors.Length];
            for (int i = 0; i < theColors.Length; i++)
            {
                _colors[i] = theColors[i];
            }
        }
        //2、current
        public object Current
        {
            get
            {
                if (_position==-1)
                {
                    throw new InvalidOperationException();
                }
                if (_position>=_colors.Length)
                {
                    throw new InvalidOperationException();
                }
                return _colors[_position];
            }
        }
        //3、moverNext
        public bool MoveNext()
        {
            if (_position<_colors.Length-1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        //4、reset
        public void Reset()
        {
            _position = -1;
        }
    }
    class Spectrum:IEnumerable
    {
        string[] colors = { "white", "blue", "gray", "black" };
        public IEnumerator GetEnumerator()
        {
            return new ColorEnumerator(colors);
        }
    }
}
