using System;
using System.Collections.Generic;
using System.Text;

namespace TODOApp
{
    class Task
    {
        private string _notes;
        private string _name;
        private DateTime _dueDate;

        #region Properties
        public string Notes
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return _dueDate;
            }
            set
            {
                _dueDate = value;
            }
        }
        #endregion
    }
}
