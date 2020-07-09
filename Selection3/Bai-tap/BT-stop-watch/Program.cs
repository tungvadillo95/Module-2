using System;

namespace BT_stop_watch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();
            stopWatch.Star();
            Console.WriteLine("Chuong trinh minh hoa Sap xep chon (Selection Sort) trong C#");
            Console.WriteLine("-------------------------------------------------------------");

            Selection_Sort selection = new Selection_Sort(100);
            selection.Sort();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.GetElapsedTime());
        }
    }
    public class Selection_Sort
    {
        private int[] data;
        private static Random ngau_nhien = new Random();

        //tao mot mang bao gom 10 so ngau nhien
        public Selection_Sort(int size)
        {
            data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = ngau_nhien.Next(1, 100);
            }
        }

        public void Sort()
        {
            Console.Write("\nSap xep cac phan tu mang theo tung buoc:\n\n");
            hien_thi_phan_tu_mang();
            int nho_nhat;
            for (int i = 0; i < data.Length - 1; i++)
            {
                nho_nhat = i;

                for (int index = i + 1; index < data.Length; index++)
                {
                    if (data[index] < data[nho_nhat])
                    {
                        nho_nhat = index;
                    }
                }
                trao_doi(i, nho_nhat);
                hien_thi_phan_tu_mang();
            }

        }

        public void trao_doi(int thu_nhat, int thu_hai)
        {
            int bien_tam = data[thu_nhat];
            data[thu_nhat] = data[thu_hai];
            data[thu_hai] = bien_tam;
        }

        public void hien_thi_phan_tu_mang()
        {
            foreach (var element in data)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n\n");
        }
    }

}
