//
//Project: Test DS
//Date:    2025/03/19
//Author:  A112223004
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using A112223004_DS_Library; //CommonMethod.cs/ShowArray
using A112223004_DS_Application;
//using A112223004_DS_Library.DS_Tree;
using System.Diagnostics.Eventing.Reader;//DS2025S

//========== Namespace TestWinForm ============//
namespace TestWinForm
{
    //============= Class frmMainEntrance ==============//
    public partial class frmMainEntrance : Form
    {

        public frmMainEntrance()
        {
            InitializeComponent();
        } // End of frmMainEntrance




        private void insertionSort<T>(T[] array, out T[] dataTarget) where T : IComparable
        {
            // 克隆数组，避免修改原数组
            dataTarget = (T[])array.Clone();

            // 插入排序算法
            for (int i = 1; i < dataTarget.Length; i++)
            {
                T key = dataTarget[i];
                int j = i - 1;

                // 将大于 key 的元素移动到后面
                while (j >= 0 && dataTarget[j].CompareTo(key) > 0)
                {
                    dataTarget[j + 1] = dataTarget[j];
                    j = j - 1;
                }
                dataTarget[j + 1] = key;
            }
        }

        void insertionSort(String[] data, out String[] dataTarget)
        {
            dataTarget = (String[])data.Clone();

            int n = dataTarget.Length;
            for (int i = 1; i < n; i++)
            {
                String key = dataTarget[i];
                int j = i - 1;

                // Move elenents that are greater than key one position ahead
                while (j >= 0 && dataTarget[j].CompareTo(key) > 0)
                {
                    dataTarget[j + 1] = dataTarget[j];
                    j--;
                }
                dataTarget[j + 1] = key;
            }
        }

        public static void selectionSort<T>(T[] source, out T[] target) where T : IComparable<T>
        {
            target = new T[source.Length];
            source.CopyTo(target, 0);
            int n = source.Length;

            for (int i = 0; i < n -1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++) //find the minmum one location
                {

                    if (target[j].CompareTo(target[minIndex]) <0) //find index of minmum number
                    {
                        minIndex = j;
                    }
                }

                if(minIndex != i) //swap
                {
                    T temp = target[minIndex];
                    target[minIndex] = target[i];
                    target[i] = temp;
                }
            }

        } //End of selectionSort

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            int[] datal = { 10, 2, 7, 5, 6 };
            int[] dataTarget1;
            double[] data2 = { 10.5, 2.5, 7.5, 5.5, 6.5 };
            double[] dataTarget2;
            string[] data3 = { "John", "Candy", "Tom", "Lily", "Bob", "Adam" };
            string[] dataTarget3;

            if (rbnInteger.Checked)
            {
                tbxtBeforeSorting.Text = "[" + string.Join(", ", datal) + "]";
                A112223004_DS_Library.DS_Sorting.insertionSort(datal, out dataTarget1);
                //insertionSort(datal, out dataTarget1);
                tbxtAfterSorting.Text = "[" + string.Join(", ", dataTarget1) + "]";
            }
            else if (rbnDouble.Checked)
            {
                tbxtBeforeSorting.Text = "[" + string.Join(", ", data2) + "]";
                A112223004_DS_Library.DS_Sorting.insertionSort(data2, out dataTarget2);
                //insertionSort(data2, out dataTarget2);
                tbxtAfterSorting.Text = "[" + string.Join(", ", dataTarget2) + "]";
            }
            else if (rbnString.Checked)
            {
                tbxtBeforeSorting.Text = "[" + string.Join(", ", data3) + "]";
                A112223004_DS_Library.DS_Sorting.insertionSort(data3, out dataTarget3);
                //insertionSort(data3, out dataTarget3);
                tbxtAfterSorting.Text = "[" + string.Join(", ", dataTarget3) + "]";
            }
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            int[] datal = { 10, 2, 7, 5, 6 };
            int[] dataTarget1;
            double[] data2 = { 10.5, 2.5, 7.5, 5.5, 6.5 };
            double[] dataTarget2;
            string[] data3 = { "John", "Candy", "Tom", "Lily", "Bob", "Adam" };
            string[] dataTarget3;

            if (rbnInteger.Checked)
            {
                tbxtBeforeSorting.Text = "[" + string.Join(", ", datal) + "]";
                A112223004_DS_Library.DS_Sorting.selectionSort(datal, out dataTarget1);
                tbxtAfterSorting.Text = "[" + string.Join(", ", dataTarget1) + "]";
            }
            else if (rbnDouble.Checked)
            {
                tbxtBeforeSorting.Text = "[" + string.Join(", ", data2) + "]";
                A112223004_DS_Library.DS_Sorting.selectionSort(data2, out dataTarget2);
                tbxtAfterSorting.Text = "[" + string.Join(", ", dataTarget2) + "]";
            }
            else if (rbnString.Checked)
            {
                tbxtBeforeSorting.Text = "[" + string.Join(", ", data3) + "]";
                A112223004_DS_Library.DS_Sorting.selectionSort(data3, out dataTarget3);
                tbxtAfterSorting.Text = "[" + string.Join(", ", dataTarget3) + "]";
            }
        }

        private void Search_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Single_btn_Click(object sender, EventArgs e)
        {
            //-- define NataNode and SLL object
            A112223004_DS_Library.LinearDateNode<int> dNode, retNode;
            A112223004_DS_Library.SinglyLL<int> sll = new A112223004_DS_Library.SinglyLL<int>();//(dNode)

            //---- add first
            int[] intData = {4,8, 3, 1, 5, 7, 9, -10 };
            for(int ii = 0; ii<intData.Length; ii++)
            {
                dNode = new A112223004_DS_Library.LinearDateNode<int>(intData[ii]);
                sll.addFirst(dNode);
            }
            /*
            dNode = new A112223004_DS_Library.LinearDateNode<int>(3);
            sll.addFirst(dNode);
            dNode = new A112223004_DS_Library.LinearDateNode<int>(1);
            sll.addFirst(dNode);
            dNode = new A112223004_DS_Library.LinearDateNode<int>(5);
            sll.addFirst(dNode);
            dNode = new A112223004_DS_Library.LinearDateNode<int>(7);
            sll.addFirst(dNode);
            dNode = new A112223004_DS_Library.LinearDateNode<int>(9);
            sll.addFirst(dNode);
            */
            tbxOriginginal.Text = sll.ToString();
            //MessageBox.Show(sll.ToString());

            //----- add last

        }

        private void Before_TextChanged(object sender, EventArgs e)
        {

        }
    } // End of class
} //End of namespace
