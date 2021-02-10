using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_Game
{
    class SudokuStandart
    {
        //создание начального поля
        public int[,] GenBase(int[,] Base, int block, int rs)
        {

            for (int s = 0; s < block; s++)
            {

                for (int j = 0; j < rs; j++)

                    if (j + 1 + s <= rs)

                        Base[1 * s * block, j] = j + 1 + s;

                    else

                        Base[1 * s * block, j] = (j + 1 + s) % rs;

                for (int i = 1; i < block; i++)
                {

                    for (int j = 0; j < rs; j++)
                    {

                        if (Base[(i + s * block) - 1, j] + block > rs)

                            Base[(i + s * block), j] = (Base[(i + s * block) - 1, j] + block) % rs;

                        else

                            Base[(i + s * block), j] = Base[(i + s * block) - 1, j] + block;

                    }

                }

            }

            return Base;

        }
        //Перемешивание
        public int[,] Transp(int[,] tran, int rs)
        {


            for (int i = 0; i < rs; i++)

                for (int j = 0; j < rs; j++)
                {

                    if (j >= i)
                    {
                        int t;
                        t = tran[i, j];
                        tran[i, j] = tran[j, i];
                        tran[j, i] = t;

                    }

                }

            return tran;

        }
        
        public int[,] SwapRow(int[,] smallRow, int block, int rs, Random r)
        {



            int a;
            int b;
            int c;

            a = r.Next(0, block);
            b = r.Next(0, block);
            c = r.Next(0, block);



            for (int i = 0; i < rs; i++)
            {
                int t;
                t = smallRow[a + c * block, i];
                smallRow[a + c * block, i] = smallRow[b + c * block, i];
                smallRow[b + c * block, i] = t;

            }

            return smallRow;

        }

        public int[,] SwapCol(int[,] smallCol, int block, int rs, Random r)
        {



            int a;
            int b;
            int c;

            a = r.Next(0, block);
            b = r.Next(0, block);
            c = r.Next(0, block);

            for (int i = 0; i < rs; i++)
            {
                int t;
                t = smallCol[i, a + c * block];
                smallCol[i, a + c * block] = smallCol[i, b + c * block];
                smallCol[i, b + c * block] = t;

            }

            return smallCol;

        }

        public int[,] SwapRows(int[,] bigRow, int block, int rs, Random r)
        {



            int a;
            int b;

            a = r.Next(0, block);
            b = r.Next(0, block);

            for (int i = 0; i < block; i++)
            {

                for (int j = 0; j < rs; j++)
                {

                    int t;
                    t = bigRow[j, i + a * block];
                    bigRow[j, i + a * block] = bigRow[j, i + b * block];
                    bigRow[j, i + b * block] = t;

                }

            }


            return bigRow;

        }

        public int[,] SwapCols(int[,] bigCol, int block, int rs, Random r)
        {



            int a;
            int b;

            a = r.Next(0, block);
            b = r.Next(0, block);

            for (int i = 0; i < block; i++)
            {

                for (int j = 0; j < rs; j++)
                {

                    int t;
                    t = bigCol[i + a * block, j];
                    bigCol[i + a * block, j] = bigCol[i + b * block, j];
                    bigCol[i + b * block, j] = t;

                }

            }

            return bigCol;

        }

    }
}
