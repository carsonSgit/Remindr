using System;
using System.Collections.Generic;
using System.Text;

namespace TODOApp
{
    class Task
    {
        #region Fields

        private string _notes;
        private string _name;
        private DateTime _dueDate;

        #endregion

        #region Constructors

        public Task()
        {
            Name = "Sample Task";
            Notes = String.Empty;
            Date = DateTime.Now;
        }

        public Task(string name, DateTime dueDate)
        {
            Name = name;
            Date = dueDate;
        }

        public Task(string name, DateTime dueDate, string notes)
        {
            Name = name;
            Date = dueDate;
            Notes = notes;
        }

        #endregion

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
