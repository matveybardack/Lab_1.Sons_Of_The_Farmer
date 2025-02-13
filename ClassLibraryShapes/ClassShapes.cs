using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryShapes
{
    /// <summary>
    /// ����� �����
    /// ���������� ������� ����� ��� �������� ���������
    /// </summary>
    public static class ClassShapes
    {
        /// <summary>
        /// ���������� ������� ����������� ��������������
        /// ��� �������� ���������
        /// </summary>
        /// <param name="perimeter">�������� ����������� ��������������</param>
        /// <returns>������� ����������� ��������������</returns>
        public static double HexagonSquare(double perimeter) // ������
        {
            //������� ��������������
            double a = perimeter / 6;

            //����� ���� ������������, ������������ �� ������� �������������� � ������ ��������� ����������
            double sin = Math.Sqrt(3) / 2;

            //������� ������������, ������������ �� ������� �������������� � ������ ��������� ����������
            double triangle_square = a * a * sin / 2;

            //������� ��������������
            double square = triangle_square * 6;
            return square;
        }

        /// <summary>
        /// ���������� ������� �����
        /// ��� �������� ���������
        /// </summary>
        /// <param name="perimeter">�������� �����</param>
        /// <returns>������� �����</returns>
        public static double CircleSquare(double perimeter) // ����
        {
            double circleSquare = Math.Pow(perimeter, 2) / (4 * Math.PI);
            return circleSquare;
        }

        /// <summary>
        /// ������� ����������� ������������ ��� �������� ���������
        /// </summary>
        /// <param name="perimeter">�������� ����������� ������������</param>
        /// <returns>������� ����������� ������������</returns>
        public static double TriangleSquare(double perimeter) // ����
        {
            //������� ������������
            double a = perimeter / 3;

            //����� ���� ������������
            double sin = Math.Sqrt(3) / 2;

            //������� ������������
            double treug_square = Math.Pow(a, 2) * sin / 2;
            return treug_square;
        }

        /// <summary>
        /// ������� ��������� ��� �������� ���������
        /// </summary>
        /// <param name="perimeter">�������� ���������</param>
        /// <returns>������� ��������</returns>
        public static double AreaSquare( double perimeter) // ����
        {
            //������� ��������
            double a = perimeter / 4;

            //������� ��������
            double kvadrat_square = Math.Pow(a, 2);
            return kvadrat_square;
        }


        /// <summary>
        /// ������� ����� �� 2 �������������� ������������� ��� �������� ���������
        /// </summary>
        /// <param name="perimeter">�������� ����� �� 2 �������������� �������������</param>
        /// <returns>������� ����� �� 2 �������������� �������������</returns>
        public static double RombSquare(double perimeter) // �����
        {
            //������� �����
            double a = perimeter / 4;

            //����� ���� �����
            double sin = Math.Sqrt(3) / 2;

            //������� �����
            double square = Math.Pow(a, 2) * sin;
            return square;
        }
        

        /// <summary>
        /// ������� �������������� ��� �������� ���������
        /// </summary>
        /// <param name="perimeter">�������� ��������������</param>
        /// <returns>������� ��������������</returns>
        public static double Square(double perimeter) // ����
        {
            //������� ������� ��������������
            double less_a = perimeter / 6;

            //������� ������� ��������������
            double more_a = less_a * 2;

            //������� ��������������
            double square = less_a * more_a;
            return square;
        }

        ///<summary>
        ///������� ����������� ��������������
        ///��� �������� ���������
        ///</summary>
        ///<param name="perimeter">�������� ����������� ��������������</param>
        ///<returns>������� ����������� ��������������</returns>
        public static double PolygonSquare(double perimeter, int sides) //������
        {
            //����� �������
            double a = perimeter / sides;

            //��������� ���� ��� �������, ����������� � ������ ��������� � n-�������� ����������, �������������� ������������,
            //������������ �� ������� n-���������
            double ctg_alfa = 1 / Math.Tan(Math.PI / sides);

            //������ ��������� ����������
            double r = (a / 2) * ctg_alfa;

            //������� ������������, ������������ �� ������� n-��������� � ������ ��������� � n-�������� ����������
            double triangle_square = r * a / 2;

            //������� ����������� ��������������
            double square = triangle_square * sides;

            return square;
        }

        public static double piFromPolygonSquare(double perimeter, int sides) //������
        {
            //����� �������
            double a = perimeter / sides;

            //��������� ���� ��� �������, ����������� � ������ ��������� � n-�������� ����������, �������������� ������������,
            //������������ �� ������� n-���������
            double ctg_alfa = 1 / Math.Tan(Math.PI / sides);

            //������ ��������� ����������
            double r = (a / 2) * ctg_alfa;

            //���������� �� �� ������� ��������� ����������
            double pi = CircleSquare(perimeter) / Math.Pow(r, 2);

            return pi;
        }
    }
}
