using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

//====== namespace =======//
namespace A112223004_DS_Library
{
    //======= Class LinkedList =========//
    public class LinkedList<E> //:LinearDataNode<E>
    {
        #region//----- Global -------//
        protected LinearDateNode<E> pHead;
        protected LinearDateNode<E> pTail;
        protected int pSize = 0;
        #endregion

        #region//----- Action -------//
        //----- Properties -------//
        public LinearDateNode<E> head { get { return pHead; } set { pHead = value; } }
        public LinearDateNode<E> tail { get { return pTail; } set { pTail = value; } }
        public int size { get { return pSize; } set { pSize = value; } }

        #region//----- Accessor/Mutator -------//
        public LinearDateNode<E> getHead() { return head; }
        public LinearDateNode<E> getTail() { return tail; }
        public int getSize() {/*findSize();*/ return pSize; }
        public void setHead(LinearDateNode<E> hh) { head = hh; findSize(); }
        public void setTail(LinearDateNode<E> tt) { tail = tt; }
        #endregion

        //----- Method --------//
        //----- find size of LL
        public void findSize()
        {
            LinearDateNode<E> nowNode = head;
            size = 0;
            while (nowNode != null)
            {
                size++;
                //MessageBox.Show("size" + size);
                nowNode = nowNode.getNext();
            }
        }//findSize

        //----- find DataNode of data
        public LinearDateNode<E> findDataNode(E data)
        {
            LinearDateNode<E> cur = head;
            while ((cur != null) && (!cur.data.Equals(data)))
            {
                cur = cur.next;
            }
            return cur;
        }

        //----- print the content of linked list
        public string toLLstring(LinearDateNode<E> dd)
        {
            string ss = "";
            LinearDateNode<E> cur;
            if (dd != null)
            {
                cur = dd;
                while (cur != null) { ss += (cur.data + "\n"); cur = cur.next; }
            }
            return ss;
        }
        #endregion
    }//end of class LinkList

    //======== Class SinglyLL =======//
    public class SinglyLL<E> : LinkedList<E>
    {
    #region//------ Action --------//
    //-------- Consructor --------//
        public SinglyLL() { head = tail = null; size = 0; }
        public SinglyLL(LinearDateNode<E> hh)
        {
            head = tail = hh;
            findSize(); //size = 1
            //MessageBox.Show(hh.getData().ToString());
        }
        //public SinglyLL(LinearDateNode<E> hh, LinearDateNode<E> tt){head = tail = tt; findSize();}

        //------ Methods -----//
        #region// ------ addFirst
        public bool addFirst(LinearDateNode<E> dn)
        {
            bool flag = true;
            try
            {
               if (dn == null) { flag = false; } // null cannot be into SLL
               else
               {
                   dn.next = head;
                   size++;
                   if (head == null) { head = tail = dn; } //only one
                   else { head = dn; }
               }
            }
            catch (Exception ee) { flag = false; }
            return flag;
        }//end of addFirst
        #endregion

        #region//----- addList
        //public bool addList(LinearDateNode<E> dn)
        //{

        //}

        public override string ToString()
        {
            string ss = "";
            ss += ("Size is" + size.ToString() + "\n");
            if (head != null) ss += ("The previous data is" + head.data.ToString() + "\n");
            if (tail != null) ss += ("The next data is" + tail.data.ToString() + "\n");
            return ss;
        }
    }// end of class SinglyL

    public class DoublyLL<E> : LinkedList<E>
    {

    }
    #endregion
    #endregion
}//end of namespace
