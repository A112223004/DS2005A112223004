//Data: 2025/03/12
//Author: A112223004
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

//===========Namespaece============//
namespace A112223004_DS_Library
{
    #region//======== Class LinearDataNode ===========//
    public class LinearDateNode<E>
    {
        #region //-------Global Data ---------//
        #region //----Private Global Varibales-------//
        private E pData;
        private LinearDateNode<E> pPrev = null;
        private LinearDateNode<E> pNext = null;
        #endregion

        #region//------Data Property ---------//
        //Public DataNode<E> prew {get ; set;}

        public LinearDateNode<E> prev { get { return pPrev; } set { pPrev = value; } }

        public LinearDateNode<E> next { get { return pNext; } set { pNext = value; } }

        public E data { get { return pData; } set { pData = value; } }
        #endregion
        #endregion

        
        #region //---------- Action ---------//
        #region //------Constructor ---------//
        public LinearDateNode() { }
        public LinearDateNode(E dd, LinearDateNode<E> pp, LinearDateNode<E> nn) { data = dd; prev = pp; next = nn; }
        public LinearDateNode(E dd, LinearDateNode<E> nn) { data = dd; prev = null; next = nn; }
        public LinearDateNode(E dd) { data = dd; prev = next = null; }

        #endregion

        //-------Accessor/Mutator -----------//
        #region//----- Accessor/Mutator -----//
        public E getData() { return data; }
        public LinearDateNode<E> getNext() {  return next; }
        public LinearDateNode<E> getPrev() { return prev; }
        public void setData(E dd) { data = dd; }
        public void setNext(LinearDateNode<E> nn) {  next = nn; }
        public void setPrev(LinearDateNode<E> pp) { prev = pp; }
        #endregion

        #region//-------Methods -------//
        //-----------Override ToString method
        public override string ToString()
        {
            string ss = "";
            ss += ("Data is" + data.ToString() + "\n");
            if (prev != null) ss += ("The previous data is" + prev.data.ToString() + "\n");
            if (next != null) ss += ("The next data is" + next.data.ToString() + "\n");
            return ss;
        }
        #endregion
        #endregion
    }//End of LinearDataNode    
    #endregion
}//End of Namespace
 