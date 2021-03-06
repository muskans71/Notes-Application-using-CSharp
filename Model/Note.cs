﻿using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Model
{

    public class Note:INotifyPropertyChanged
    {
		private int id;

		[PrimaryKey, AutoIncrement]
		public int Id
		{
			get { return id; }
			set { id = value;
				OnPropertyChanged("Id");
			}
		}
		private int notebookid;

		[Indexed]
		public int NotebookId
		{
			get { return notebookid; }
			set { notebookid = value;
				OnPropertyChanged("NotebookId");
			}
		}

		private string title;

		public string Title
		{
			get { return title; }
			set { title = value;
				OnPropertyChanged("Title");
			}
		}



		private DateTime createdtime;

		public DateTime CreateTime
		{
			get { return createdtime; }
			set { createdtime = value;
				OnPropertyChanged("CreateTime");
			}
		}

		private DateTime updatedtime;

		public DateTime UpdatedTime
		{
			get { return updatedtime; }
			set { updatedtime = value;
				OnPropertyChanged("UpdatedTime");
			}
		}
		private string fileLocation;

		

		public string FileLocation
		{
			get { return fileLocation; }
			set { fileLocation = value;
				OnPropertyChanged("FileLocation");
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
