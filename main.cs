using System;

namespace IkeIkeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // 画面に表示するアートのサイズを設定
            int width = 40;
            int height = 20;

            // アートの形をランダムに決める
            Random random = new Random();
            int shape = random.Next(1, 4);

            // イケイケなアートを生成して表示
            GenerateArt(width, height, shape);
        }

        // イケイケなアートを生成する関数
        static void GenerateArt(int width, int height, int shape)
        {
            // シェイプごとに異なるパターンを生成
            switch (shape)
            {
                case 1:
                    GenerateDiagonalPattern(width, height);
                    break;
                case 2:
                    GenerateTrianglePattern(width, height);
                    break;
                case 3:
                    GenerateCheckerboardPattern(width, height);
                    break;
                default:
                    Console.WriteLine("Invalid shape selected.");
                    break;
            }
        }

        // 対角線パターンを生成する関数
        static void GenerateDiagonalPattern(int width, int height)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == y || x == width - y - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        // 三角形パターンを生成する関数
        static void GenerateTrianglePattern(int width, int height)
        {
            int center = width / 2;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x >= center - y && x <= center + y)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        // チェッカーボードパターンを生成する関数
        static void GenerateCheckerboardPattern(int width, int height)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
