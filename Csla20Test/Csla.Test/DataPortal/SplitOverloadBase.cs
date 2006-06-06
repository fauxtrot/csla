using System;
using System.Collections.Generic;
using System.Text;

namespace Csla.Test.DataPortalTest
{
    [Serializable()]
    public abstract class SplitOverloadBase<T> : Csla.BusinessBase<T>
        where T : SplitOverloadBase<T>
    {
        #region Business Methods

        // TODO: add your own fields, properties and methods
        private int _id;

        public int id
        {
            get
            {
                CanReadProperty(true);
                return _id;
            }
            set
            {
                CanWriteProperty(true);
                if (_id != value)
                {
                    _id = value;
                    PropertyHasChanged();
                }
            }
        }

        protected override object GetIdValue()
        {
            return _id;
        }

        #endregion


        #region Factory Methods

        public static T NewObject()
        {
          return Csla.DataPortal.Create<T>();
        }
        public static T NewObjectWithCriteria()
        {
          return Csla.DataPortal.Create<T>(new Criteria1(0));
        }

        public static T GetObject(int id)
        {
          return Csla.DataPortal.Fetch<T>(new Criteria(id));
        }
        public static void DeleteObject(int id)
        {
          Csla.DataPortal.Delete(new Criteria(id));
        }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria : CriteriaBase
        {
            private int _id;
            public int Id
            {
                get { return _id; }
            }
            public Criteria(int id)
                : base(typeof(T))
            { _id = id; }
        }
        [Serializable()]
        private class Criteria1 : CriteriaBase
        {
            private int _id;
            public int Id
            {
                get { return _id; }
            }
            public Criteria1(int id)
                : base(typeof(T))
            { _id = id; }
        }

        private void DataPortal_Create(object criteria)
        {
            _id = 0;
            Csla.ApplicationContext.GlobalContext.Clear();
            ApplicationContext.GlobalContext.Add("SplitOverload", "Created");
        }
        private void DataPortal_Create(Criteria1 criteria)
        {
            _id = 0;
            Csla.ApplicationContext.GlobalContext.Clear();
            ApplicationContext.GlobalContext.Add("SplitOverload", "Created1");
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            _id = criteria.Id;
            Csla.ApplicationContext.GlobalContext.Clear();
            ApplicationContext.GlobalContext.Add("SplitOverload", "Fetched");
        }
        private void DataPortal_Fetch(Criteria1 criteria)
        {
            _id = criteria.Id;
            Csla.ApplicationContext.GlobalContext.Clear();
            ApplicationContext.GlobalContext.Add("SplitOverload", "Fetched1");
        }
        private void DataPortal_Delete(Criteria criteria)
        {
            Csla.ApplicationContext.GlobalContext.Clear();
            ApplicationContext.GlobalContext.Add("SplitOverload", "Deleted");
        }
        private void DataPortal_Delete(Criteria1 criteria)
        {
            Csla.ApplicationContext.GlobalContext.Clear();
            ApplicationContext.GlobalContext.Add("SplitOverload", "Deleted1");
        }
        #endregion

    }
}
